using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarCenter.Data;
using CarCenter.Models;
using CarCenter.Models.Enums;

namespace CarCenter.Controllers
{
    public class NotasController : Controller
    {
        private readonly CarCenterContext _context;

        public NotasController(CarCenterContext context)
        {
            _context = context;
        }

        // GET: Notas
        public async Task<IActionResult> Index()
        {
            var carCenterContext = _context.Notas.Include(n => n.Carro).Include(n => n.Comprador).Include(n => n.Vendedor);
            return View(await carCenterContext.ToListAsync());
        }

        // GET: Notas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Notas == null)
            {
                return NotFound();
            }

            var nota = await _context.Notas
                .Include(n => n.Carro)
                .Include(n => n.Comprador)
                .Include(n => n.Vendedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nota == null)
            {
                return NotFound();
            }

            return View(nota);
        }

        // GET: Notas/Create
        public IActionResult Create()
        {
            ViewData["CarroId"] = new SelectList(_context.Carros, "Id", "Chassi");
            ViewData["CompradorId"] = new SelectList(_context.Clientes, "Id", "CPF");
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Matricula");
            return View();
        }

        // POST: Notas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Numero,DataEmissao,Garantia,ValorVenda,CompradorId,VendedorId,CarroId")] Nota nota)
        {
            if (!ModelState.IsValid)
            {
                ViewData["CarroId"] = new SelectList(_context.Carros, "Id", "Chassi", nota.CarroId);
                ViewData["CompradorId"] = new SelectList(_context.Clientes, "Id", "CPF", nota.CompradorId);
                ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Matricula", nota.VendedorId);
                return View(nota);
            }
            _context.Add(nota);
            await _context.SaveChangesAsync();

            Carro? carro = _context.Carros.FirstOrDefault(c => c.Id == nota.CarroId);
            if (carro == null) return View(nota);
            carro.CarroStatus = CarroStatus.VENDIDO;
            _context.Carros.Update(carro);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Notas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Notas == null)
            {
                return NotFound();
            }

            var nota = await _context.Notas.FindAsync(id);
            if (nota == null)
            {
                return NotFound();
            }
            ViewData["CarroId"] = new SelectList(_context.Carros, "Id", "Chassi", nota.CarroId);
            ViewData["CompradorId"] = new SelectList(_context.Clientes, "Id", "CPF", nota.CompradorId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Matricula", nota.VendedorId);
            return View(nota);
        }

        // POST: Notas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Numero,DataEmissao,Garantia,ValorVenda,CompradorId,VendedorId,CarroId")] Nota nota)
        {
            if (id != nota.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotaExists(nota.Id))
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
            ViewData["CarroId"] = new SelectList(_context.Carros, "Id", "Chassi", nota.CarroId);
            ViewData["CompradorId"] = new SelectList(_context.Clientes, "Id", "CPF", nota.CompradorId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Matricula", nota.VendedorId);
            return View(nota);
        }

        // GET: Notas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Notas == null)
            {
                return NotFound();
            }

            var nota = await _context.Notas
                .Include(n => n.Carro)
                .Include(n => n.Comprador)
                .Include(n => n.Vendedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nota == null)
            {
                return NotFound();
            }

            return View(nota);
        }

        // POST: Notas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Notas == null)
            {
                return Problem("Entity set 'CarCenterContext.Notas'  is null.");
            }
            var nota = await _context.Notas.FindAsync(id);
            if (nota != null)
            {
                _context.Notas.Remove(nota);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaExists(int id)
        {
          return (_context.Notas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
