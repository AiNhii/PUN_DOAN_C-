using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_db.Models;

namespace Web_db.Controllers
{
    public class PostsandtagsController : Controller
    {
        private readonly PunContext _context;

        public PostsandtagsController(PunContext context)
        {
            _context = context;
        }

        // GET: Postsandtags
        public async Task<IActionResult> Index()
        {
            var punContext = _context.Postsandtags.Include(p => p.Post).Include(p => p.Tag);
            return View(await punContext.ToListAsync());
        }

        // GET: Postsandtags/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postsandtag = await _context.Postsandtags
                .Include(p => p.Post)
                .Include(p => p.Tag)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postsandtag == null)
            {
                return NotFound();
            }

            return View(postsandtag);
        }

        // GET: Postsandtags/Create
        public IActionResult Create()
        {
            ViewData["PostId"] = new SelectList(_context.Posts, "Id", "Slug");
            ViewData["TagId"] = new SelectList(_context.Posttags, "Id", "Slug");
            return View();
        }

        // POST: Postsandtags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PostId,TagId")] Postsandtag postsandtag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(postsandtag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PostId"] = new SelectList(_context.Posts, "Id", "Slug", postsandtag.PostId);
            ViewData["TagId"] = new SelectList(_context.Posttags, "Id", "Slug", postsandtag.TagId);
            return View(postsandtag);
        }

        // GET: Postsandtags/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postsandtag = await _context.Postsandtags.FindAsync(id);
            if (postsandtag == null)
            {
                return NotFound();
            }
            ViewData["PostId"] = new SelectList(_context.Posts, "Id", "Slug", postsandtag.PostId);
            ViewData["TagId"] = new SelectList(_context.Posttags, "Id", "Slug", postsandtag.TagId);
            return View(postsandtag);
        }

        // POST: Postsandtags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,PostId,TagId")] Postsandtag postsandtag)
        {
            if (id != postsandtag.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postsandtag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostsandtagExists(postsandtag.Id))
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
            ViewData["PostId"] = new SelectList(_context.Posts, "Id", "Slug", postsandtag.PostId);
            ViewData["TagId"] = new SelectList(_context.Posttags, "Id", "Slug", postsandtag.TagId);
            return View(postsandtag);
        }

        // GET: Postsandtags/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postsandtag = await _context.Postsandtags
                .Include(p => p.Post)
                .Include(p => p.Tag)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postsandtag == null)
            {
                return NotFound();
            }

            return View(postsandtag);
        }

        // POST: Postsandtags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var postsandtag = await _context.Postsandtags.FindAsync(id);
            _context.Postsandtags.Remove(postsandtag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostsandtagExists(long id)
        {
            return _context.Postsandtags.Any(e => e.Id == id);
        }
    }
}
