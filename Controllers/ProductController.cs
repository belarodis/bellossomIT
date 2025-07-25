using bellossomIT.Models;
using Microsoft.AspNetCore.Mvc;
using bellossomIT.Services;
namespace bellossomIT.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _service;
        public ProductController(ProductService service)
        {
            _service = service;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Flower(string category)
        {
            var flowers = await _service.GetAllFlowersAsync();
            ViewBag.products = flowers;
            return View(category);
        }
        [HttpGet]
        public IActionResult AddFlower()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> AddFlower(FlowerModel flower)
        {

            Console.WriteLine($"Id: {flower.Id}, ArrivalDate: {flower.arrivalDate}, Species: {flower.species}, Quantity: {flower.quantity}");
            await _service.AddAsync(flower);
            return RedirectToAction("Flower");
        }
        
        public async Task<IActionResult> Fertilizer(string category)
        {
            var fertilizers = await _service.GetAllFertilizersAsync();
            ViewBag.products = fertilizers;
            return View(category);
        }
        
        public async Task<IActionResult> Vase(string category)
        {
            var vases = await _service.GetAllVasesAsync();
            ViewBag.products = vases;
            return View(category);
        }
        
        [HttpPost]
        public async Task<IActionResult> IncreaseQuantity(int id)
        {
            await _service.IncreaseQuantity(id); // 
            
            return RedirectToAction(GetReturnAction());
        }

        [HttpPost]
        public async Task<IActionResult> DecreaseQuantity(int id)
        {
            await _service.DecreaseQuantity(id); //
            
            return RedirectToAction(GetReturnAction());
        }

        private string GetReturnAction()
        {
            var referer = Request.Headers["Referer"].ToString();

            if (referer.Contains("/Fertilizer"))
                return "Fertilizer";

            if (referer.Contains("/Flower"))
                return "Flower";

            if (referer.Contains("/Vase"))
                return "Vase";

            return "Index";
        }

    }
}   
