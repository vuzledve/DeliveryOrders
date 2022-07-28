using DeliveryOrders_3.Domain;
using DeliveryOrders_3.Domain.Entities;
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
        //public IActionResult Create()
        //{
        //    return View(new CreateOrderViewModel());
        //}

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
              //  return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
        //public IActionResult Edit(Guid id)
        //{
        //    var entity = id == default ?  : dataManager.ServiceItems.GetServiceItemById(id);
        //    return View(entity);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Login(CreateOrderViewModel model, string returnUrl)
        //{
        //    if (ModelState.IsValid) //если все валидно
        //    {
        //        IdentityUser user = await userManager.FindByNameAsync(model.UserName);
        //        if (user != null)
        //        {
        //            await signInManager.SignOutAsync();
        //            Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
        //            if (result.Succeeded)
        //            {
        //                return Redirect(returnUrl ?? "/");
        //            }
        //        }
        //        ModelState.AddModelError(nameof(LoginViewModel.UserName), "Неверный логин или пароль");
        //    }
        //    return View(model);
        //}

    }
}
