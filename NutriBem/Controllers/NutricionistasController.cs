using System;
using System.Collections.Generic;
using System.Linq;
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
    public class NutricionistasController : Controller
    {
        private readonly AppDbContext _context;

        public NutricionistasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Nutricionistas
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nutricionistas.ToListAsync());
        }

        // GET: Nutricionistas/Details/5
        [Authorize]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutricionista = await _context.Nutricionistas
                .FirstOrDefaultAsync(m => m.Cpf == id);
            if (nutricionista == null)
            {
                return NotFound();
            }

            return View(nutricionista);
        }

        // GET: Nutricionistas/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nutricionistas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create([Bind("Crn,Nome,Email,DataNascimento,Senha,Cpf,Telefone")] Nutricionista nutricionista)
        {

            if (ModelState.IsValid)
            {
                nutricionista.Senha = BCrypt.Net.BCrypt.HashPassword(nutricionista.Senha);
                _context.Add(nutricionista);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return View(nutricionista);
        }

        // GET: Nutricionistas/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutricionista = await _context.Nutricionistas.FindAsync(id);
            if (nutricionista == null)
            {
                return NotFound();
            }
            return View(nutricionista);
        }

        // POST: Nutricionistas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(string id, [Bind("Crn,Nome,Email,DataNascimento,Senha,Cpf,Telefone")] Nutricionista nutricionista)
        {
            if (id != nutricionista.Cpf)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    nutricionista.Senha = BCrypt.Net.BCrypt.HashPassword(nutricionista.Senha);
                    _context.Update(nutricionista);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NutricionistaExists(nutricionista.Cpf))
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
            return View(nutricionista);
        }

        // GET: Nutricionistas/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutricionista = await _context.Nutricionistas
                .FirstOrDefaultAsync(m => m.Cpf == id);
            if (nutricionista == null)
            {
                return NotFound();
            }

            return View(nutricionista);
        }

        // POST: Nutricionistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nutricionista = await _context.Nutricionistas.FindAsync(id);
            if (nutricionista != null)
            {
                _context.Nutricionistas.Remove(nutricionista);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NutricionistaExists(string id)
        {
            return _context.Nutricionistas.Any(e => e.Cpf == id);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Nutricionista nutricionista)
        {
            //Armazena na variável a linha da tabela nutricionistas referente ao CPF passado pelo usuário na View
            var dados = await _context.Nutricionistas.FindAsync(nutricionista.Cpf);

            //Verifica se os dados por acaso são nulos. Se forem, a mensagem abaixo aparece por meio da ViewBag
            if(dados == null)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
                return View();
            }

            //o método abaixo recebe dois parâmetros: o primeiro é a senha passada pelo usuário e o outro é a senha do banco de dados.
            //a variável recebe um valor booleano conforme o resultado da verificação feita pelo método BCrypt
            bool senhaEstaCorreta = BCrypt.Net.BCrypt.Verify(nutricionista.Senha, dados.Senha);

            //se a senha está correta, é feita a autenticação do usuário
            if (senhaEstaCorreta)
            {
                //cria as credenciais do usuário
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dados.Nome),
                    new Claim(ClaimTypes.NameIdentifier, dados.Cpf.ToString()),
                    new Claim(ClaimTypes.Role, "nutricionista" )
                };

                //"envelopa" as credeciais do usuário
                var nutricionistaIdentidade = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(nutricionistaIdentidade);

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

            return RedirectToAction("Login", "Nutricionistas");
        }
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
