using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nutricionistas.ToListAsync());
        }

        // GET: Nutricionistas/Details/5
        public async Task<IActionResult> Details(int? id)
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
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nutricionistas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cpf,Nome,Email,DataNascimento,Senha,Telefone,Crn")] Nutricionista nutricionista)
        {
            if (ModelState.IsValid)
            {
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Nutricionista ON");
                _context.Add(nutricionista);
                await _context.SaveChangesAsync();
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Nutricionista OFF");
                return RedirectToAction(nameof(Index));
            }
            return View(nutricionista);
        }

        // GET: Nutricionistas/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
        public async Task<IActionResult> Edit(int id, [Bind("Crn,Nome,Email,DataNascimento,Senha,Cpf,Telefone")] Nutricionista nutricionista)
        {
            if (id != nutricionista.Cpf)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
        public async Task<IActionResult> Delete(int? id)
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
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nutricionista = await _context.Nutricionistas.FindAsync(id);
            if (nutricionista != null)
            {
                _context.Nutricionistas.Remove(nutricionista);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NutricionistaExists(int id)
        {
            return _context.Nutricionistas.Any(e => e.Cpf == id);
        }
    }
}
