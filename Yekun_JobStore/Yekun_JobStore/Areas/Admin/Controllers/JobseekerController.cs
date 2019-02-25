using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yekun_JobStore.Models;

namespace Yekun_JobStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,sUser,aUser")]
    public class JobseekerController : Controller
    {
        private readonly JobstoreDbContext _context;

        public JobseekerController(JobstoreDbContext context)
        {
            _context = context;
        }

        // GET: Menus
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobSeekers.ToListAsync());
        }

        // GET: Menus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seekers = await _context.JobSeekers
                .FirstOrDefaultAsync(s => s.ID == id);
            if (seekers == null)
            {
                return NotFound();
            }

            return View(seekers);
        }

        // GET: Menus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Menus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,JobName,SocialNetworks,Link,SubCategory,Salary,Experience,Education,City,WorkTime,Birthday,Email,Phone,Knowledge,SetTime,About,ViewCount,PhotoPath")] JobSeeker seeker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seeker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seeker);
        }

        // GET: Menus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seeker = await _context.JobSeekers.FindAsync(id);
            if (seeker == null)
            {
                return NotFound();
            }
            return View(seeker);
        }

        // POST: Menus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,JobName,SocialNetworks,Link,SubCategory,Salary,Experience,Education,City,WorkTime,Birthday,Email,Phone,Knowledge,SetTime,About,ViewCount,PhotoPath")] JobSeeker seeker)
        {
            if (id != seeker.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seeker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobseekerExists(seeker.ID))
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
            return View(seeker);
        }

        // GET: Menus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seeker = await _context.JobSeekers
                .FirstOrDefaultAsync(s => s.ID == id);
            if (seeker == null)
            {
                return NotFound();
            }

            return View(seeker);
        }

        // POST: Menus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seeker = await _context.JobSeekers.FindAsync(id);
            _context.JobSeekers.Remove(seeker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobseekerExists(int id)
        {
            return _context.JobSeekers.Any(e => e.ID == id);
        }
    }
}
