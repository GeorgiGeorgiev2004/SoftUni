using Microsoft.AspNetCore.Mvc;
using MyFirstMVCProject.Models.Product;
using System.Text.Json;

namespace MyFirstMVCProject.Controllers
{
    public class ProductController : Controller
    {
        private IEnumerable<ProductViewModel>products = new List<ProductViewModel>() 
        {
            new ProductViewModel()
            {
                Id = 1,
                Name = "Cheese",
                Price = 7.00
            },
            new ProductViewModel()
            {
                Id = 2,
                Name = "Ham",
                Price = 5.50
            },
            new ProductViewModel()
            {
                Id = 3,
                Name = "Bread",
                Price = 1.50
            }
        };
        public IActionResult All() 
        {
            return View(products);
        }

        public IActionResult ById(int? id)
        {
            var product = products.FirstOrDefault(p=>p.Id==id);
            if (product == null) 
            {
                return NotFound();
            }
            return View(product);
        }
        public IActionResult AllAsJson() 
        {
            return Json(products,new JsonSerializerOptions 
            {
                WriteIndented = true
            });
        }
        public IActionResult AllAsText()
        {
            string result="";
            foreach (var p in products)
            {
                result += $"Product {p.Id}: {p.Name} - {p.Price} lv.\r\n";
            }
            return Content(result);
        }
    }
}
