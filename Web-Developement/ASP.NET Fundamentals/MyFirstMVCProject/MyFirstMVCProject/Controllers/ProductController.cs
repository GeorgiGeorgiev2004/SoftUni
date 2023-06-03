using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using MyFirstMVCProject.Models.Product;
using System.Text;
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
        [ActionName("My-Products")]
        public IActionResult All(string word) 
        {
            if (!string.IsNullOrWhiteSpace(word))
            {
                var ProductsSearch = products.Where(p => p.Name
                .ToLower().Contains(word.ToLower()));
                return View(ProductsSearch);
            }
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
        public IActionResult AllAsTextFile()
        {
            StringBuilder result = new StringBuilder();
            foreach (var p in products)
            {
                result.AppendLine( $"Product {p.Id}: {p.Name} - {p.Price:f2} lv.");
            }
            Response.Headers.Add(HeaderNames.ContentDisposition, @"attachment;filename=products.txt");
            return File(Encoding.UTF32.GetBytes(result.ToString().TrimEnd()),"text/plain");
        }
    }
}
