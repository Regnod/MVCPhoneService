using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Repo;

namespace MVCPhoneServiceWeb.Controllers
{
    public class MobilePhoneCallingPlanAssignmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MobilePhoneCallingPlanAssignmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MobilePhoneCallingPlanAssignments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MobilePhoneCallingPlanAssignments.Include(m => m.CallingPlan).Include(m => m.PhoneLine);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MobilePhoneCallingPlanAssignments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobilePhoneCallingPlanAssignment = await _context.MobilePhoneCallingPlanAssignments
                .Include(m => m.CallingPlan)
                .Include(m => m.PhoneLine)
                .FirstOrDefaultAsync(m => m.PhoneNumber == id);
            if (mobilePhoneCallingPlanAssignment == null)
            {
                return NotFound();
            }

            return View(mobilePhoneCallingPlanAssignment);
        }

        // GET: MobilePhoneCallingPlanAssignments/Create
        public IActionResult Create()
        {
            ViewData["CallingPlanId"] = new SelectList(_context.CallingPlans, "CallingPlanId", "CallingPlanId");
            ViewData["PhoneNumber"] = new SelectList(_context.PhoneLines, "PhoneNumber", "PhoneNumber");
            return View();
        }

        // POST: MobilePhoneCallingPlanAssignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhoneNumber,CallingPlanAssignmentDateTime,CallingPlanId,MinutesConsumed,MessagesSent")] MobilePhoneCallingPlanAssignment mobilePhoneCallingPlanAssignment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mobilePhoneCallingPlanAssignment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CallingPlanId"] = new SelectList(_context.CallingPlans, "CallingPlanId", "CallingPlanId", mobilePhoneCallingPlanAssignment.CallingPlanId);
            ViewData["PhoneNumber"] = new SelectList(_context.PhoneLines, "PhoneNumber", "PhoneNumber", mobilePhoneCallingPlanAssignment.PhoneNumber);
            return View(mobilePhoneCallingPlanAssignment);
        }

        // GET: MobilePhoneCallingPlanAssignments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobilePhoneCallingPlanAssignment = await _context.MobilePhoneCallingPlanAssignments.FindAsync(id);
            if (mobilePhoneCallingPlanAssignment == null)
            {
                return NotFound();
            }
            ViewData["CallingPlanId"] = new SelectList(_context.CallingPlans, "CallingPlanId", "CallingPlanId", mobilePhoneCallingPlanAssignment.CallingPlanId);
            ViewData["PhoneNumber"] = new SelectList(_context.PhoneLines, "PhoneNumber", "PhoneNumber", mobilePhoneCallingPlanAssignment.PhoneNumber);
            return View(mobilePhoneCallingPlanAssignment);
        }

        // POST: MobilePhoneCallingPlanAssignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhoneNumber,CallingPlanAssignmentDateTime,CallingPlanId,MinutesConsumed,MessagesSent")] MobilePhoneCallingPlanAssignment mobilePhoneCallingPlanAssignment)
        {
            if (id != mobilePhoneCallingPlanAssignment.PhoneNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mobilePhoneCallingPlanAssignment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MobilePhoneCallingPlanAssignmentExists(mobilePhoneCallingPlanAssignment.PhoneNumber))
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
            ViewData["CallingPlanId"] = new SelectList(_context.CallingPlans, "CallingPlanId", "CallingPlanId", mobilePhoneCallingPlanAssignment.CallingPlanId);
            ViewData["PhoneNumber"] = new SelectList(_context.PhoneLines, "PhoneNumber", "PhoneNumber", mobilePhoneCallingPlanAssignment.PhoneNumber);
            return View(mobilePhoneCallingPlanAssignment);
        }

        // GET: MobilePhoneCallingPlanAssignments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobilePhoneCallingPlanAssignment = await _context.MobilePhoneCallingPlanAssignments
                .Include(m => m.CallingPlan)
                .Include(m => m.PhoneLine)
                .FirstOrDefaultAsync(m => m.PhoneNumber == id);
            if (mobilePhoneCallingPlanAssignment == null)
            {
                return NotFound();
            }

            return View(mobilePhoneCallingPlanAssignment);
        }

        // POST: MobilePhoneCallingPlanAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mobilePhoneCallingPlanAssignment = await _context.MobilePhoneCallingPlanAssignments.FindAsync(id);
            _context.MobilePhoneCallingPlanAssignments.Remove(mobilePhoneCallingPlanAssignment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MobilePhoneCallingPlanAssignmentExists(int id)
        {
            return _context.MobilePhoneCallingPlanAssignments.Any(e => e.PhoneNumber == id);
        }
    }
}
