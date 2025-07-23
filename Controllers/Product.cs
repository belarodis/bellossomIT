using Microsoft.AspNetCore.Mvc;

namespace bellossomIT.Controllers
{
    public class Product : Controller
    {
        private readonly IProductRepository _productRepo;
        public ProductsController(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }
        // GET: Product
        public ActionResult Index()
        {
            //var products(p/ abaixo, mudar o nome da variavel p um codigo mais legível) = _productRepo.GetAll(ou get by category)(); fazer dps um get by category, manda o tipo e recebe só a de certo tipo
            //return View(products);
            return View();
        }

        public ActionResult Flower(string category)
        {
            //pegar os produtos dessa categoria
            return View(category);
        }
        
        public ActionResult Fertilizer(string category)
        {
            //pegar os produtos dessa categoria
            return View(category);
        }
        
        public ActionResult Vase(string category)
        {
            //pegar os produtos dessa categoria, vamos usar ViewData
            return View(category);
        }
    }
}   
