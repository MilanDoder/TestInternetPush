using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DiplomskiRad.Models;

namespace DiplomskiRad.Controllers
{
    public class ManufacturerController : Controller
    {
        private readonly ManufacturerContext _context;

        public ManufacturerController(ManufacturerContext context)
        {
            _context = context;
        }

        // GET: Manufacturer
        public async Task<IActionResult> Index()
        {
            return View(await _context.Manufacturers.ToListAsync());
        }


        // GET: Manufacturer/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Manufacturer());
            else
                return View(_context.Manufacturers.Find(id));
        }

        // POST: Manufacturer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Name,PhoneNumber,Address,Email")] Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                if (manufacturer.Id == 0)
                {
                    _context.Add(manufacturer);

                }
                else {
                    _context.Update(manufacturer);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(manufacturer);
        }


        // GET: Manufacturer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manufacturer = await _context.Manufacturers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            return View(manufacturer);
        }

    }
}
