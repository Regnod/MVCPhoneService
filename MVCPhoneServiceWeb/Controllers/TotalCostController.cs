using System;
using System.Collections.Generic;
using System.Globalization;
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

        public IActionResult CostCenterExpenseLandline(string month, string year)
        {
            int _month = Utils.IntTryParse(month);
            int _year = Utils.IntTryParse(year);
            
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
            
            if (_month != -1 && _year != 1)
            {
                join = join.Where(a => a.Date.Year == _year && a.Date.Month == _month);
            }
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

        public IActionResult CostCenterExpenseMobile(string month, string year)
        {
            int _month = Utils.IntTryParse(month);
            int _year = Utils.IntTryParse(year);

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
            
            if (_month != -1 && _year != 1)
            {
                join2 = join2.Where(a => a.Date.Year == _year && a.Date.Month == _month);
            }
            
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