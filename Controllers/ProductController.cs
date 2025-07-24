using Microsoft.AspNetCore.Mvc;
using bellossomIT.Models.Repository;
namespace bellossomIT.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;
        public ProductController(IProductRepository productRepo)
        {
            _repository = repository;
        }
        // GET: Product
        public ActionResult Index()
        {
            //var products(p/ abaixo, mudar o nome da variavel p um codigo mais legível) = _productRepo.GetAll(ou get by category)(); fazer dps um get by category, manda o tipo e recebe só a de certo tipo
            //return View(products);
            return View();
        }

        public async Task<IActionResult> Flower(string category)
        {
            //pegar os produtos dessa categoria
            var flowers = await _repository.GetAllFlowerAsync();
            ViewBag.products = flowers;
            return View(category);
        }
        
        public async Task<IActionResult> Fertilizer(string category)
        {
            //pegar os produtos dessa categoria
            var fertilizers = await _repository.GetAllFertilizersAsync();
            ViewBag.products = fertilizers;
            return View(category);
        }
        
        public async Task<IActionResult> Vase(string category)
        {
            //pegar os produtos dessa categoria, vamos usar ViewData
            var vases = await _repository.GetAllVasesAsync();
            ViewBag.products = vases;
            return View(category);
        }
    }
}   
