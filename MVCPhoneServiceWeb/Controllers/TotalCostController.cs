using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Data;
using Microsoft.EntityFrameworkCore;
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

        // public IActionResult Index()
        // {
        //     var a = _context.Employees.Join(
        //         _context.MobilePhoneEmployees,
        //         a => a.EmployeeId,
        //         b => b.EmployeeId,
        //         (a, b) => new
        //         {
        //             EmployeeId = a.EmployeeId,
        //             MobilePhone = b.MobilePhone,
        //             Name = a.EmployeeName
        //         }).ToList();
        //     return View();
        // }
    }
}