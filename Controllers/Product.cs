using Microsoft.AspNetCore.Mvc;

namespace bellossomIT.Controllers
{
    public class Product : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
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
