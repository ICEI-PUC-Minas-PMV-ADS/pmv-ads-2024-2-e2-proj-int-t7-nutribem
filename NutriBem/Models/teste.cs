using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace NutriBem.Models
{
    public class teste : Controller
    {
        private readonly AppDbContext _context;

        public teste(AppDbContext context)
        {
            _context = context;
        }

        // GET: teste
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Refeicoes.Include(r => r.PlanoAlimentar).Include(r => r.Receita);
            return View(await appDbContext.ToListAsync());
        }

        // GET: teste/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refeicao = await _context.Refeicoes
                .Include(r => r.PlanoAlimentar)
                .Include(r => r.Receita)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refeicao == null)
            {
                return NotFound();
            }

            return View(refeicao);
        }

        // GET: teste/Create
        public IActionResult Create()
        {
            ViewData["PlanoAlimentarId"] = new SelectList(_context.PlanosAlimentares, "Id", "Descricao");
            ViewData["ReceitaId"] = new SelectList(_context.Receitas, "Id", "IngredienteQuantidade");
            return View();
        }

        // POST: teste/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipo,Hora,PlanoAlimentarId,ReceitaId")] Refeicao refeicao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(refeicao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlanoAlimentarId"] = new SelectList(_context.PlanosAlimentares, "Id", "Descricao", refeicao.PlanoAlimentarId);
            ViewData["ReceitaId"] = new SelectList(_context.Receitas, "Id", "IngredienteQuantidade", refeicao.ReceitaId);
            return View(refeicao);
        }

        // GET: teste/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refeicao = await _context.Refeicoes.FindAsync(id);
            if (refeicao == null)
            {
                return NotFound();
            }
            ViewData["PlanoAlimentarId"] = new SelectList(_context.PlanosAlimentares, "Id", "Descricao", refeicao.PlanoAlimentarId);
            ViewData["ReceitaId"] = new SelectList(_context.Receitas, "Id", "IngredienteQuantidade", refeicao.ReceitaId);
            return View(refeicao);
        }

        // POST: teste/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipo,Hora,PlanoAlimentarId,ReceitaId")] Refeicao refeicao)
        {
            if (id != refeicao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refeicao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefeicaoExists(refeicao.Id))
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
            ViewData["PlanoAlimentarId"] = new SelectList(_context.PlanosAlimentares, "Id", "Descricao", refeicao.PlanoAlimentarId);
            ViewData["ReceitaId"] = new SelectList(_context.Receitas, "Id", "IngredienteQuantidade", refeicao.ReceitaId);
            return View(refeicao);
        }

        // GET: teste/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refeicao = await _context.Refeicoes
                .Include(r => r.PlanoAlimentar)
                .Include(r => r.Receita)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refeicao == null)
            {
                return NotFound();
            }

            return View(refeicao);
        }

        // POST: teste/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var refeicao = await _context.Refeicoes.FindAsync(id);
            if (refeicao != null)
            {
                _context.Refeicoes.Remove(refeicao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RefeicaoExists(int id)
        {
            return _context.Refeicoes.Any(e => e.Id == id);
        }
    }
}
