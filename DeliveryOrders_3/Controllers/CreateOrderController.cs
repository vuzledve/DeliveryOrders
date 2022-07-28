using DeliveryOrders_3.Domain;
using DeliveryOrders_3.Models;
using DeliveryOrders_3.Service;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryOrders_3.Controllers
{
    public class CreateOrderController : Controller
    {
        private readonly DataManager dataManager; //для доступа к бд
        public CreateOrderController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Create()
        {
            var entity = new DeliveryOrder();
            return View(entity);
        }

        [HttpPost]
        public IActionResult Create(DeliveryOrder model)
        {
            if (ModelState.IsValid)
            {  
                dataManager.DeliveryOrders.SaveDeliveryOrder(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

    }
}
