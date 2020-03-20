using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Data;
using Microsoft.EntityFrameworkCore;
using MVCPhoneServiceWeb.ViewModels;
using Repo;

namespace MVCPhoneServiceWeb.Controllers
{
    public class TotalCostController : Controller
    {
        private ApplicationDbContext _context;

        public TotalCostController(ApplicationDbContext context)
        {
            _context = context;
        }

        //TODO Esto es solamente con las llamadas desde telefonos fijos 
        public IActionResult CostCenterExpenseLandline()
        {
            var join = _context.Employees.Join(
                _context.LandLinePhoneCalls,
                a => a.EmployeeId,
                b => b.EmployeeId,
                (a, b) => new
                {
                    CostCenter = a.CostCenter,
                    Expense = b.LandlinePhoneCallCost,
                    Date = b.LandlinePhoneCallDateTime
                });
           // var a = join.Where(a => a.Date.Day == 12 && a.Date.Month==12);
            List<TotalCostViewModel> viewModel = new List<TotalCostViewModel>();
            if (join.Count() != 0)
            {
                var group = join.GroupBy(a => a.CostCenter);
                foreach (var item in group)
                {
                    foreach (var item2 in item)
                    {
                        viewModel.Add(new TotalCostViewModel()
                            {Expense = item2.Expense, CostCenter = item2.CostCenter});
                    }
                }
            }

            return View(viewModel);
        }

        public IActionResult CostCenterExpenseMobile()
        {
            var join = _context.MobilePhoneCalls.Join(
                _context.PhoneLineEmployees,
                a => a.PhoneNumber,
                b => b.PhoneNumber,
                (a, b) => new
                {
                    EmployeeId = b.EmployeeId,
                    MobilePhoneCallCost = a.MobilePhoneCallCost,
                    Date = a.DateTime
                });
            var join2 = join.Join(
                _context.Employees,
                a => a.EmployeeId,
                b => b.EmployeeId,
                (a, b) => new
                {
                    CostCenter = b.CostCenter,
                    Expense = a.MobilePhoneCallCost,
                    Date = a.Date
                });
            List<TotalCostViewModel> viewModel = new List<TotalCostViewModel>();
            if (join2.Count() != 0)
            {
                var group = join2.GroupBy(a => a.CostCenter);
                foreach (var item in group)
                {
                    foreach (var item2 in item)
                    {
                        viewModel.Add(new TotalCostViewModel()
                            {Expense = item2.Expense, CostCenter = item2.CostCenter});
                    }
                }
            }
            return View(viewModel);
        }
    }
}
