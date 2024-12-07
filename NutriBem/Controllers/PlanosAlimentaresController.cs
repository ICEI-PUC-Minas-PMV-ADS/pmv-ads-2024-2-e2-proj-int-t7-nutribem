using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NutriBem.Models;

namespace NutriBem.Controllers
{
    [Authorize]
    public class PlanosAlimentaresController : Controller
    {
        private readonly AppDbContext _context;

        public PlanosAlimentaresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PlanosAlimentares
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlanosAlimentares.ToListAsync());
        }

        // GET: PlanosAlimentares/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoAlimentar = await _context.PlanosAlimentares
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planoAlimentar == null)
            {
                return NotFound();
            }

            return View(planoAlimentar);
        }

        [Authorize(Roles = "nutricionista")]
        // GET: PlanosAlimentares/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlanosAlimentares/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Nomepaciente,Objetivo,Descricao,Observacao")] PlanoAlimentar planoAlimentar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planoAlimentar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planoAlimentar);
        }

        // GET: PlanosAlimentares/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoAlimentar = await _context.PlanosAlimentares
                .Include(p => p.Refeicoes)
                .ThenInclude(r => r.Receita)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (planoAlimentar == null)
            {
                return NotFound();
            }
            return View(planoAlimentar);
        }

        // POST: PlanosAlimentares/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Nomepaciente,Objetivo,Descricao,Observacao")] PlanoAlimentar planoAlimentar)
        {
            if (id != planoAlimentar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planoAlimentar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanoAlimentarExists(planoAlimentar.Id))
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
            return View(planoAlimentar);
        }

        // GET: PlanosAlimentares/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planoAlimentar = await _context.PlanosAlimentares
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planoAlimentar == null)
            {
                return NotFound();
            }

            return View(planoAlimentar);
        }

        // POST: PlanosAlimentares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planoAlimentar = await _context.PlanosAlimentares.FindAsync(id);
            if (planoAlimentar != null)
            {
                _context.PlanosAlimentares.Remove(planoAlimentar);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanoAlimentarExists(int id)
        {
            return _context.PlanosAlimentares.Any(e => e.Id == id);
        }

        public async Task<IActionResult> RefeicoesPartial(int id)
        {
            var refeicoes = await _context.Refeicoes
                .Include(r => r.Receita)
                .Where(r => r.PlanoAlimentarId == id)
                .ToListAsync();

            return PartialView("_PartialListRefeicoes", refeicoes);
        }

        public async Task<IActionResult> CreateRefeicaoPartial(int planoAlimentarId)
        {
            // Log para ver se a ação é chamada corretamente
            Console.WriteLine($"Plano Alimentar ID: {planoAlimentarId}");

            var receitas = await _context.Receitas.ToListAsync();
            ViewBag.Receitas = new SelectList(receitas, "Id", "Nome");
            ViewBag.PlanoAlimentarId = planoAlimentarId;
            return PartialView("_PartialCreateRefeicoes", new Refeicao());
        }


        public async Task<IActionResult> EditRefeicaoPartial(int id)
        {
            // Obtém a refeição pelo id
            var refeicao = await _context.Refeicoes
                .Include(r => r.Receita)  // Certifique-se de incluir as receitas
                .FirstOrDefaultAsync(r => r.Id == id);

            // Se não encontrar a refeição
            if (refeicao == null)
            {
                return NotFound();
            }

            // Passa as receitas para o dropdown na view
            var receitas = await _context.Receitas.ToListAsync();
            ViewBag.Receitas = new SelectList(receitas, "Id", "Nome");

            // Retorna a partial view com os dados da refeição
            return PartialView("_PartialEditRefeicoes", refeicao);
        }



    }
}
