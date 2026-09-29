using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> products = new List<Product>
        {
            new Product
            {
                ID = 1,
                ProductName = "Laptop",
                Price = 55000,
                Category = "Electronics"
            },

            new Product
            {
                ID = 2,
                ProductName = "Mobile",
                Price = 25000,
                Category = "Electronics"
            },

            new Product
            {
                ID = 3,
                ProductName = "Headphones",
                Price = 2000,
                Category = "Accessories"
            }
        };

        public ActionResult Index()
        {
            return View(products);
        }

        public ActionResult Details(int id)
        {
            Product product = products.FirstOrDefault(p => p.ID == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}
