using Microsoft.AspNetCore.Mvc;
using Infrastructure.Repositories;
using Core.Domain;

namespace TooGoodToGo.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;

        public ProductController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult ProductsByPackage(int packageId)
        {
            var products = _productRepository.GetProductsByPackage(new Package { Id = packageId });
            return View(products);
        }
    }
}
