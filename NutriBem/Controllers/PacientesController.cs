using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NutriBem.Models;


namespace NutriBem.Controllers
{
    public class PacientesController : Controller
    {
        private readonly AppDbContext _context;

        public PacientesController(AppDbContext context)
        {
            _context = context;
        }
        
        // GET: Pacientes/Details/5
        [Authorize]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes
                .FirstOrDefaultAsync(m => m.Cpf == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // GET: Pacientes/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            ViewData["CpfNutricionista"] = new SelectList(_context.Nutricionistas, "Cpf", "Nome");
            return View();
        }

        // POST: Pacientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create([Bind("Altura,Peso,Pagante,Nome,Email,DataNascimento,Senha,Cpf,Telefone, CpfNutricionista")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                paciente.Senha = BCrypt.Net.BCrypt.HashPassword(paciente.Senha);
                _context.Add(paciente); 
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            ViewData["CpfNutricionista"] = new SelectList(_context.Nutricionistas, "Cpf", "Nome", paciente.CpfNutricionista);
            return View(paciente);
        }

        // GET: Pacientes/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }
            ViewData["CpfNutricionista"] = new SelectList(_context.Nutricionistas, "Cpf", "Nome", paciente.CpfNutricionista);
            return View(paciente);
        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(string id, [Bind("Altura,Peso,Pagante,CpfNutricionista,Nome,Email,DataNascimento,Senha,Cpf,Telefone")] Paciente paciente)
        {
            if (id != paciente.Cpf)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    paciente.Senha = BCrypt.Net.BCrypt.HashPassword(paciente.Senha);
                    _context.Update(paciente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacienteExists(paciente.Cpf))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(paciente);
        }

        // GET: Pacientes/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes
                .FirstOrDefaultAsync(m => m.Cpf == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacienteExists(string id)
        {
            return _context.Pacientes.Any(e => e.Cpf == id);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Paciente paciente)
        {
            //Armazena na variável a linha da tabela pacientes referente ao CPF passado pelo usuário na View
            var dados = await _context.Pacientes.FindAsync(paciente.Cpf);

            //Verifica se os dados por acaso são nulos. Se forem, a mensagem abaixo aparece por meio da ViewBag
            if (dados == null)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
                return View();
            }

            //o método abaixo recebe dois parâmetros: o primeiro é a senha passada pelo usuário e o outro é a senha do banco de dados.
            //a variável recebe um valor booleano conforme o resultado da verificação feita pelo método BCrypt
            bool senhaEstaCorreta = BCrypt.Net.BCrypt.Verify(paciente.Senha, dados.Senha);

            //se a senha está correta, é feita a autenticação do usuário
            if (senhaEstaCorreta)
            {
                //cria as credenciais do usuário
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dados.Nome),
                    new Claim(ClaimTypes.NameIdentifier, dados.Cpf.ToString()),
                    new Claim(ClaimTypes.Role, "paciente")
                };

                //"envelopa" as credeciais do usuário
                var pacienteIdentidade = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(pacienteIdentidade);

                //define em quanto tempo a senha do usuário vai expirar
                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    //define que a senha expira em oito horas
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    //persistent no cookie do usuário.
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");
            }
            else
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
            }
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login", "Pacientes");
        }
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> MeuPerfil(string id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (userId != id)
            {
                return RedirectToAction("AccessDenied", "Nutricionistas");
            }
            if (id == null) return NotFound();
            var paciente = await _context.Pacientes
                .Where(c => c.Cpf == id)
                .ToListAsync();
            var meuNutricionista = await _context.Nutricionistas
                .Where(c => c.Cpf == paciente[0].CpfNutricionista)
                .ToListAsync();
;
            ViewBag.MeuPerfil = meuNutricionista;


            return View(paciente);
        }
    }
}
