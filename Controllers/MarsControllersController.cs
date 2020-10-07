using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Laboratory6.Data;
using Laboratory6.Models;

namespace Laboratory6.Controllers
{
    public class MarsControllersController : Controller
    {
        private readonly AuthorizationContext _context;

        public MarsControllersController(AuthorizationContext context)
        {
            _context = context;
        }

        // GET: MarsControllers
        public async Task<IActionResult> Index(string searchString)
        {
            var movies = from m in _context.MarsControllers
                         select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Login.Contains(searchString));
            }

            return View(await movies.ToListAsync());
        }

        // GET: MarsControllers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marsController = await _context.MarsControllers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marsController == null)
            {
                return NotFound();
            }

            return View(marsController);
        }

        // GET: MarsControllers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MarsControllers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Login,Password,ReleaseDate,Email,Number,Country")] MarsController marsController)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marsController);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(marsController);
        }

        // GET: MarsControllers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marsController = await _context.MarsControllers.FindAsync(id);
            if (marsController == null)
            {
                return NotFound();
            }
            return View(marsController);
        }

        // POST: MarsControllers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Login,Password,ReleaseDate,Email,Number,Country")] MarsController marsController)
        {
            if (id != marsController.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marsController);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarsControllerExists(marsController.Id))
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
            return View(marsController);
        }

        // GET: MarsControllers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marsController = await _context.MarsControllers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (marsController == null)
            {
                return NotFound();
            }

            return View(marsController);
        }

        // POST: MarsControllers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var marsController = await _context.MarsControllers.FindAsync(id);
            _context.MarsControllers.Remove(marsController);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarsControllerExists(int id)
        {
            return _context.MarsControllers.Any(e => e.Id == id);
        }
    }
}
