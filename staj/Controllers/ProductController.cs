using Microsoft.AspNetCore.Mvc;
using staj.Models;


namespace staj.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _repository;

        public ProductController()
        {
            _repository = new ProductRepository();
        }

        public IActionResult Index()
        {
            var products = _repository.GetAllProducts();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _repository.AddProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}

