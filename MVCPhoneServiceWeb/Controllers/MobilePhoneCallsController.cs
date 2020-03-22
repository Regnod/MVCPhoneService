﻿using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Repo;

namespace MVCPhoneServiceWeb.Controllers
{
    public class MobilePhoneCallsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MobilePhoneCallsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MobilePhoneCalls
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MobilePhoneCalls.Include(m => m.MobilePhone).Include(m => m.PhoneLine);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MobilePhoneCalls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobilePhoneCall = await _context.MobilePhoneCalls
                .Include(m => m.MobilePhone)
                .Include(m => m.PhoneLine)
                .FirstOrDefaultAsync(m => m.PhoneNumber == id);
            if (mobilePhoneCall == null)
            {
                return NotFound();
            }

            return View(mobilePhoneCall);
        }

        // GET: MobilePhoneCalls/Create
        public IActionResult Create()
        {
            ViewData["IMEI"] = new SelectList(_context.MobilePhones, "IMEI", "IMEI");
            ViewData["PhoneNumber"] = new SelectList(_context.PhoneLines, "PhoneNumber", "PhoneNumber");
            return View();
        }

        // POST: MobilePhoneCalls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhoneNumber,IMEI,DateTime,MobilePhoneCallAddressee,MobilePhoneCallDuration,MobilePhoneCallCost")] MobilePhoneCall mobilePhoneCall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mobilePhoneCall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IMEI"] = new SelectList(_context.MobilePhones, "IMEI", "IMEI", mobilePhoneCall.IMEI);
            ViewData["PhoneNumber"] = new SelectList(_context.PhoneLines, "PhoneNumber", "PhoneNumber", mobilePhoneCall.PhoneNumber);
            return View(mobilePhoneCall);
        }

        // GET: MobilePhoneCalls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobilePhoneCall = await _context.MobilePhoneCalls.FindAsync(id);
            if (mobilePhoneCall == null)
            {
                return NotFound();
            }
            ViewData["IMEI"] = new SelectList(_context.MobilePhones, "IMEI", "IMEI", mobilePhoneCall.IMEI);
            ViewData["PhoneNumber"] = new SelectList(_context.PhoneLines, "PhoneNumber", "PhoneNumber", mobilePhoneCall.PhoneNumber);
            return View(mobilePhoneCall);
        }

        // POST: MobilePhoneCalls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhoneNumber,IMEI,DateTime,MobilePhoneCallAddressee,MobilePhoneCallDuration,MobilePhoneCallCost")] MobilePhoneCall mobilePhoneCall)
        {
            if (id != mobilePhoneCall.PhoneNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mobilePhoneCall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MobilePhoneCallExists(mobilePhoneCall.PhoneNumber))
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
            ViewData["IMEI"] = new SelectList(_context.MobilePhones, "IMEI", "IMEI", mobilePhoneCall.IMEI);
            ViewData["PhoneNumber"] = new SelectList(_context.PhoneLines, "PhoneNumber", "PhoneNumber", mobilePhoneCall.PhoneNumber);
            return View(mobilePhoneCall);
        }

        // GET: MobilePhoneCalls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobilePhoneCall = await _context.MobilePhoneCalls
                .Include(m => m.MobilePhone)
                .Include(m => m.PhoneLine)
                .FirstOrDefaultAsync(m => m.PhoneNumber == id);
            if (mobilePhoneCall == null)
            {
                return NotFound();
            }

            return View(mobilePhoneCall);
        }

        // POST: MobilePhoneCalls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mobilePhoneCall = await _context.MobilePhoneCalls.FindAsync(id);
            _context.MobilePhoneCalls.Remove(mobilePhoneCall);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MobilePhoneCallExists(int id)
        {
            return _context.MobilePhoneCalls.Any(e => e.PhoneNumber == id);
        }
    }
}
