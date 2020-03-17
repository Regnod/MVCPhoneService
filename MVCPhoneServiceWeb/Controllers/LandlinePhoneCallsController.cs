using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Repo;
using  System.Linq;

namespace MVCPhoneServiceWeb.Controllers
{
    public class LandlinePhoneCallsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LandlinePhoneCallsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LandlinePhoneCalls
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.LandLinePhoneCalls.Include(l => l.Employee);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: LandlinePhoneCalls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landlinePhoneCall = await _context.LandLinePhoneCalls
                .Include(l => l.Employee)
                .FirstOrDefaultAsync(m => m.Extension == id);
            if (landlinePhoneCall == null)
            {
                return NotFound();
            }

            return View(landlinePhoneCall);
        }

        // GET: LandlinePhoneCalls/Create
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "EmployeeId");
            return View();
        }

        // POST: LandlinePhoneCalls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Extension,LandlinePhoneCallDateTime,EmployeeId,Destination,LandlinePhoneCallDuration,LandlinePhoneCallAddressee")] LandlinePhoneCall landlinePhoneCall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(landlinePhoneCall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "EmployeeId", landlinePhoneCall.EmployeeId);
            return View(landlinePhoneCall);
        }

        // GET: LandlinePhoneCalls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landlinePhoneCall = await _context.LandLinePhoneCalls.FindAsync(id);
            if (landlinePhoneCall == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "EmployeeId", landlinePhoneCall.EmployeeId);
            return View(landlinePhoneCall);
        }

        // POST: LandlinePhoneCalls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Extension,LandlinePhoneCallDateTime,EmployeeId,Destination,LandlinePhoneCallDuration,LandlinePhoneCallAddressee")] LandlinePhoneCall landlinePhoneCall)
        {
            if (id != landlinePhoneCall.Extension)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(landlinePhoneCall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LandlinePhoneCallExists(landlinePhoneCall.Extension))
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
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "EmployeeId", landlinePhoneCall.EmployeeId);
            return View(landlinePhoneCall);
        }

        // GET: LandlinePhoneCalls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landlinePhoneCall = await _context.LandLinePhoneCalls
                .Include(l => l.Employee)
                .FirstOrDefaultAsync(m => m.Extension == id);
            if (landlinePhoneCall == null)
            {
                return NotFound();
            }

            return View(landlinePhoneCall);
        }

        // POST: LandlinePhoneCalls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var landlinePhoneCall = await _context.LandLinePhoneCalls.FindAsync(id);
            _context.LandLinePhoneCalls.Remove(landlinePhoneCall);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LandlinePhoneCallExists(int id)
        {
            return _context.LandLinePhoneCalls.Any(e => e.Extension == id);
        }
    }
}
