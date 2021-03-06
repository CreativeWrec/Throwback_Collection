﻿using System;
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
    public class CollectorWishlistsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CollectorWishlistsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CollectorWishlists
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Wishlists.Include(c => c.Collector).Include(c => c.Item);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CollectorWishlists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var collectorWishlist = await _context.Wishlists
                .Include(c => c.Collector)
                .Include(c => c.Item)
                .FirstOrDefaultAsync(m => m.CollectorId == id);
            if (collectorWishlist == null)
            {
                return NotFound();
            }

            return View(collectorWishlist);
        }

        // GET: CollectorWishlists/Create
        public IActionResult Create()
        {
            ViewData["CollectorId"] = new SelectList(_context.Collectors, "CollectorId", "CollectorId");
            ViewData["ItemId"] = new SelectList(_context.Items, "ItemId", "ItemId");
            return View();
        }

        // POST: CollectorWishlists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WishList,CollectorId,ItemId")] CollectorWishlist collectorWishlist)
        {
            if (ModelState.IsValid)
            {
                _context.Add(collectorWishlist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CollectorId"] = new SelectList(_context.Collectors, "CollectorId", "CollectorId", collectorWishlist.CollectorId);
            ViewData["ItemId"] = new SelectList(_context.Items, "ItemId", "ItemId", collectorWishlist.ItemId);
            return View(collectorWishlist);
        }

        // GET: CollectorWishlists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var collectorWishlist = await _context.Wishlists.FindAsync(id);
            if (collectorWishlist == null)
            {
                return NotFound();
            }
            ViewData["CollectorId"] = new SelectList(_context.Collectors, "CollectorId", "CollectorId", collectorWishlist.CollectorId);
            ViewData["ItemId"] = new SelectList(_context.Items, "ItemId", "ItemId", collectorWishlist.ItemId);
            return View(collectorWishlist);
        }

        // POST: CollectorWishlists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WishList,CollectorId,ItemId")] CollectorWishlist collectorWishlist)
        {
            if (id != collectorWishlist.CollectorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(collectorWishlist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CollectorWishlistExists(collectorWishlist.CollectorId))
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
            ViewData["CollectorId"] = new SelectList(_context.Collectors, "CollectorId", "CollectorId", collectorWishlist.CollectorId);
            ViewData["ItemId"] = new SelectList(_context.Items, "ItemId", "ItemId", collectorWishlist.ItemId);
            return View(collectorWishlist);
        }

        // GET: CollectorWishlists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var collectorWishlist = await _context.Wishlists
                .Include(c => c.Collector)
                .Include(c => c.Item)
                .FirstOrDefaultAsync(m => m.CollectorId == id);
            if (collectorWishlist == null)
            {
                return NotFound();
            }

            return View(collectorWishlist);
        }

        // POST: CollectorWishlists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var collectorWishlist = await _context.Wishlists.FindAsync(id);
            _context.Wishlists.Remove(collectorWishlist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CollectorWishlistExists(int id)
        {
            return _context.Wishlists.Any(e => e.CollectorId == id);
        }
    }
}
