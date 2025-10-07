//Safa Atout
//Student#: 991620668

using Microsoft.AspNetCore.Mvc;
using PizzaAppSafa.BusinessLayer;
using PizzaAppSafa.Models;

namespace PizzaAppSafa.Controllers
{
    public class PizzaController : Controller
    {

        private readonly IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to Safa’s Pizza Corner!";
            return View();
        }
        [HttpPost]
        public IActionResult Receipt(PizzaOrder order)
        {

            if (string.IsNullOrWhiteSpace(order.CustomerName) || order.Quantity <= 0)
            {
                ViewBag.Error = "Please fill in all fields correctly.";
                return View("Index");
            }


            var receipt = _pizzaService.CalculateBill(order);


            return View(receipt);
        }
    }
}
