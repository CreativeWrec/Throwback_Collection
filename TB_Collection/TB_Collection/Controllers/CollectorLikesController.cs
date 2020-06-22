using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TB_Collection.Data;
using TB_Collection.Models;

namespace TB_Collection.Controllers
{
    public class CollectorLikesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CollectorLikesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CollectorLikes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CollectorLikes.Include(c => c.Collector).Include(c => c.Item);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CollectorLikes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var collectorLikes = await _context.CollectorLikes
                .Include(c => c.Collector)
                .Include(c => c.Item)
                .FirstOrDefaultAsync(m => m.CollectorId == id);
            if (collectorLikes == null)
            {
                return NotFound();
            }

            return View(collectorLikes);
        }

        // GET: CollectorLikes/Create
        public IActionResult Create()
        {
            ViewData["CollectorId"] = new SelectList(_context.Collectors, "CollectorId", "CollectorId");
            ViewData["ItemId"] = new SelectList(_context.Items, "ItemId", "ItemId");
            return View();
        }

        // POST: CollectorLikes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IsDislike,CollectorId,ItemId")] CollectorLikes collectorLikes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(collectorLikes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CollectorId"] = new SelectList(_context.Collectors, "CollectorId", "CollectorId", collectorLikes.CollectorId);
            ViewData["ItemId"] = new SelectList(_context.Items, "ItemId", "ItemId", collectorLikes.ItemId);
            return View(collectorLikes);
        }

        // GET: CollectorLikes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var collectorLikes = await _context.CollectorLikes.FindAsync(id);
            if (collectorLikes == null)
            {
                return NotFound();
            }
            ViewData["CollectorId"] = new SelectList(_context.Collectors, "CollectorId", "CollectorId", collectorLikes.CollectorId);
            ViewData["ItemId"] = new SelectList(_context.Items, "ItemId", "ItemId", collectorLikes.ItemId);
            return View(collectorLikes);
        }

        // POST: CollectorLikes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IsDislike,CollectorId,ItemId")] CollectorLikes collectorLikes)
        {
            if (id != collectorLikes.CollectorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(collectorLikes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CollectorLikesExists(collectorLikes.CollectorId))
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
            ViewData["CollectorId"] = new SelectList(_context.Collectors, "CollectorId", "CollectorId", collectorLikes.CollectorId);
            ViewData["ItemId"] = new SelectList(_context.Items, "ItemId", "ItemId", collectorLikes.ItemId);
            return View(collectorLikes);
        }

        // GET: CollectorLikes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var collectorLikes = await _context.CollectorLikes
                .Include(c => c.Collector)
                .Include(c => c.Item)
                .FirstOrDefaultAsync(m => m.CollectorId == id);
            if (collectorLikes == null)
            {
                return NotFound();
            }

            return View(collectorLikes);
        }

        // POST: CollectorLikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var collectorLikes = await _context.CollectorLikes.FindAsync(id);
            _context.CollectorLikes.Remove(collectorLikes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CollectorLikesExists(int id)
        {
            return _context.CollectorLikes.Any(e => e.CollectorId == id);
        }
    }
}
