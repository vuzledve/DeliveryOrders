using DeliveryOrders_3.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryOrders_3.Controllers
{
    public class OrdersListController : Controller
    {
        private readonly DataManager dataManager;

        public OrdersListController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.DeliveryOrders.GetDeliveryOrders());
        }

    }
}
