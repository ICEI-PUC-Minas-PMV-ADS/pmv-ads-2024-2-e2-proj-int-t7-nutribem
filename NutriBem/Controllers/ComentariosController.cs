using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NutriBem.Models;
using Microsoft.AspNetCore.Authorization;


namespace NutriBem.Controllers
{
    [Authorize]
    public class ComentariosController : Controller
    {
        private readonly AppDbContext _context;

        public ComentariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Comentarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Comentarios.ToListAsync());
        }

        // GET: Comentarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Comentarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Conteudo")] Comentario comentario)
        {
            if (ModelState.IsValid)
            {
                comentario.DataHora = DateTime.Now;  // Define a data e hora atuais
                _context.Add(comentario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comentario);
        }

        // GET: Comentarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentarios.FindAsync(id);
            if (comentario == null)
            {
                return NotFound();
            }
            return View(comentario);
        }

        // POST: Comentarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Conteudo,DataHora")] Comentario comentario)
        {
            if (id != comentario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comentario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComentarioExists(comentario.Id))
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
            return View(comentario);
        }

        // GET: Comentarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comentario == null)
            {
                return NotFound();
            }

            return View(comentario);
        }

        // POST: Comentarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var comentario = await _context.Comentarios.FindAsync(id);

                if (comentario == null)
                {
                    return NotFound(); // Retorna 404 se o comentário não existir
                }

                _context.Comentarios.Remove(comentario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // Redireciona para o Index após a deleção
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Erro ao deletar comentário: {ex.Message}");
                return View(); // Retorna para a view com o erro, se houver
            }
        }

        private bool ComentarioExists(int id)
        {
            return _context.Comentarios.Any(e => e.Id == id);
        }
    }
}
