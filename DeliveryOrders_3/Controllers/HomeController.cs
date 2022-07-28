using Microsoft.AspNetCore.Mvc;

namespace DeliveryOrders_3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrder()
        {
            return View();
        }
    }
}
