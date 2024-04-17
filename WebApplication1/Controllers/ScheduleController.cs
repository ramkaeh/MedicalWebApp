using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
