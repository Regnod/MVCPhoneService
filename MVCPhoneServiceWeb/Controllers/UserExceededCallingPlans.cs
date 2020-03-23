using Microsoft.AspNetCore.Mvc;

namespace MVCPhoneServiceWeb.Controllers
{
    public class UserExceededCallingPlans : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}