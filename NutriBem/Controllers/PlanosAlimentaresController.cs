﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NutriBem.Models;

namespace NutriBem.Controllers
{
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

            var planoAlimentar = await _context.PlanosAlimentares.FindAsync(id);
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
    }
}
