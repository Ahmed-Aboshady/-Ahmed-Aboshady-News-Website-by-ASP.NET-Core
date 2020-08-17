using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewsApp.Data;
using NewsApp.Models;
using System.IO;

namespace NewsApp.Controllers
{
    [Area("Admin")]
    public class TeammembersController : Controller
    {
        private readonly NewsContext _context;
        private IHostingEnvironment host;

        public TeammembersController(NewsContext context, IHostingEnvironment hostEnv)
        {
            _context = context;
            host = hostEnv;
        }
        void uploadphote(Teammember model)
        {
            if (model.File != null)
            {
                string uploadsFolder = Path.Combine(host.WebRootPath, "images");
                string uniqueFileName = Guid.NewGuid() + ".jpg";
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    model.File.CopyTo(filestream);
                }
                model.Image = uniqueFileName;

            }
        }
        // GET: Teammembers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teammembers.ToListAsync());
        }

        // GET: Teammembers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teammember = await _context.Teammembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teammember == null)
            {
                return NotFound();
            }

            return View(teammember);
        }

        // GET: Teammembers/Create
        public IActionResult Create()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Teammember teammember)
        {
            if (ModelState.IsValid)
            {
                uploadphote(teammember);
                _context.Add(teammember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teammember);
        }

        // GET: Teammembers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teammember = await _context.Teammembers.FindAsync(id);
            if (teammember == null)
            {
                return NotFound();
            }
            return View(teammember);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Teammember teammember)
        {
            if (id != teammember.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    uploadphote(teammember);
                    _context.Update(teammember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeammemberExists(teammember.Id))
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
            return View(teammember);
        }

        // GET: Teammembers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teammember = await _context.Teammembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teammember == null)
            {
                return NotFound();
            }

            return View(teammember);
        }

        // POST: Teammembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teammember = await _context.Teammembers.FindAsync(id);
            _context.Teammembers.Remove(teammember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeammemberExists(int id)
        {
            return _context.Teammembers.Any(e => e.Id == id);
        }
    }
}
