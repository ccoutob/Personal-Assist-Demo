using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _Personal_Assist_Beta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _Personal_Assist_Beta.Controllers
{
    public class SuporteController : Controller
    {
        private readonly Contexto _context;

        public SuporteController(Contexto context)
        {
            _context = context;
        }

        // GET: Pedidos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Suporte.ToListAsync());
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suporte = await _context.Suporte
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suporte == null)
            {
                return NotFound();
            }

            return View(suporte);
        }

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Problema,Status,Prioridade")] Suporte suporte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suporte);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(suporte);
        }

        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suporte = await _context.Suporte.FindAsync(id);
            if (suporte == null)
            {
                return NotFound();
            }
            return View(suporte);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Problema,Status,Prioridade")] Suporte suporte)
        {
            if (id != suporte.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suporte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuporteExists(suporte.Id))
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
            return View(suporte);
        }

        // GET: Pedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suporte = await _context.Suporte
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suporte == null)
            {
                return NotFound();
            }

            return View(suporte);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suporte = await _context.Suporte.FindAsync(id);
            if (suporte != null)
            {
                _context.Suporte.Remove(suporte);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuporteExists(int id)
        {
            return _context.Suporte.Any(e => e.Id == id);
        }
    }
}

