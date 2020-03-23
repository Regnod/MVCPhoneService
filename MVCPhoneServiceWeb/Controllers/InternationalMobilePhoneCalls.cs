using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repo;

namespace MVCPhoneServiceWeb.Controllers
{
    public class InternationalMobilePhoneCall : Controller
    {
        private ApplicationDbContext _context;

        public InternationalMobilePhoneCall(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET
        public async Task<IActionResult> Index(string month, string year)
        {
            int _month = Utils.Utils.IntTryParse(month);
            int _year = Utils.Utils.IntTryParse(year);

            var join1 = await _context.MobilePhoneCalls.Join(
                _context.PhoneLineEmployees,
                a => a.PhoneNumber,
                a => a.PhoneNumber,
                (a, b) => new
                {
                    EmployeeId = b.EmployeeId,
                    PhoneNumber = a.PhoneNumber,
                    DateTime = a.DateTime,
                    Addressee = a.MobilePhoneCallAddressee,
                    Cost = a.MobilePhoneCallCost,
                }).ToListAsync();

            var join2 = join1.Join(
                await _context.Employees.ToListAsync(),
                a => a.EmployeeId,
                a => a.EmployeeId,
                (a, b) => new
                {
                    EmployeeId = a.EmployeeId,
                    EmployeeName = b.EmployeeName,
                    PhoneNumber = a.PhoneNumber,
                    DateTime = a.DateTime,
                    Addresse = a.Addressee,
                    Cost = a.Cost,
                }
            );
            if (_month != -1)
            {
                join2 = join2.Where(a => a.DateTime.Month == _month);
            }

            if (_year != -1)
            {
                join2 = join2.Where(a => a.DateTime.Year == _year);
            }

            Dictionary<int,int> phoneNumberInterExpenses = new Dictionary<int, int>();
            foreach (var item in join2)
            {
                //if (item.Addresse.ToString()[^1] == '1')
                {
                    int cost;
                    if(phoneNumberInterExpenses.TryGetValue())
                }
            }
            return View();
        }
    }
}