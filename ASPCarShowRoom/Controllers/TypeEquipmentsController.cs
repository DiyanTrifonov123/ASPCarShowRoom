using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPCarShowRoom.Data;
using ASPCarShowRoom.Models;

namespace ASPCarShowRoom.Controllers
{
    public class TypeEquipmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TypeEquipmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TypeEquipments
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeEquipments.ToListAsync());
        }

        // GET: TypeEquipments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeEquipment = await _context.TypeEquipments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeEquipment == null)
            {
                return NotFound();
            }

            return View(typeEquipment);
        }

        // GET: TypeEquipments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeEquipments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")] TypeEquipment typeEquipment)
        {
            typeEquipment.RegisterOn = DateTime.Now;
            if (ModelState.IsValid)
            {
                _context.Add(typeEquipment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeEquipment);
        }

        // GET: TypeEquipments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeEquipment = await _context.TypeEquipments.FindAsync(id);
            if (typeEquipment == null)
            {
                return NotFound();
            }
            return View(typeEquipment);
        }

        // POST: TypeEquipments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name")] TypeEquipment typeEquipment)
        {
            typeEquipment.RegisterOn = DateTime.Now;
            if (id != typeEquipment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeEquipment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeEquipmentExists(typeEquipment.Id))
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
            return View(typeEquipment);
        }

        // GET: TypeEquipments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeEquipment = await _context.TypeEquipments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeEquipment == null)
            {
                return NotFound();
            }

            return View(typeEquipment);
        }

        // POST: TypeEquipments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeEquipment = await _context.TypeEquipments.FindAsync(id);
            if (typeEquipment != null)
            {
                _context.TypeEquipments.Remove(typeEquipment);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeEquipmentExists(int id)
        {
            return _context.TypeEquipments.Any(e => e.Id == id);
        }
    }
}
