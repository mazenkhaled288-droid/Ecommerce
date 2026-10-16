using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Ecommerce.DataAccess;
using Microsoft.EntityFrameworkCore;
using Ecommerce.enums;



namespace Ecommerce.Areas.Customer.Controllers
{
    [Area(AreaConstants.CUSTOMER_AREA)]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db=new ApplicationDbContext();
        public IActionResult Index(ProductFilter filter)
        {
            var products = db.products.AsQueryable();

            products = products.Include(e => e.Category);

            switch (filter)
            {
                case ProductFilter.AllProducts:
                    break;
                case ProductFilter.TopView:
                    products = products.OrderByDescending(e => e.Traffic);
                    break;
                case ProductFilter.TopDiscount:
                    products=products.OrderByDescending(e => e.Discount);
                    break;
            }


            products = products.Skip(0).Take(8);

            return View(products);
        }

        public IActionResult Details( int id)
        {
            var product = db.products.Include(e => e.Category).SingleOrDefault(e => e.ID == id);

            if (product is null) return NotFound();

            var relatedproducts = db.products.Include(e => e.Category).Where(e => e.CategoryId == product.CategoryId && e.ID!= id);

            return View(new productItemWithRelatedVM()
            {
                product= product,
                RelatedProducts= relatedproducts
            }
                );

        }


        public IActionResult Privacy()
        {
            return View();
        }

        public ViewResult Welcome()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
