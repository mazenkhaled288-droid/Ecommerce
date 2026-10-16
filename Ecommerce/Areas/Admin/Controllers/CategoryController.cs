using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area(AreaConstants.ADMIN_AREA)]
    public class CategoryController : Controller
    {
   private readonly ApplicationDbContext _db=new ApplicationDbContext();
        public IActionResult Index(string name,int page=1,int size=3)
        {
            var categories=_db.Categories.AsQueryable();
            if (name is not null)
            {
                categories = categories.Where(e => e.Name.ToLower().Contains(name.ToLower()));
            }
            int totalItems=categories.Count();

            int totalPages = (int)Math.Ceiling((double)totalItems / size);

            categories =categories.Skip((page-1)*size).Take(size);

            return View(new CategoryitemWithRelatedVM
            {
                Categories= categories,
                Name=name ?? "",
                TotalPages=totalPages,
                CurrentPage=page

            });
            
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string name,bool states,string description)
        {
            _db.Categories.Add(new()
            {
                Name=name,
                Description=description,
                States=states
            });
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var Category=_db.Categories.FirstOrDefault(e=>e.ID==id);
            if (Category == null)
            {
                return NotFound();
            }

            return View(Category);
        }
        [HttpPost]
        public IActionResult Update(int id,string name,string description,bool states)
        {
            var Category=_db.Categories.FirstOrDefault(e=>e.ID==id);

            if (Category == null)
            {
                return NotFound();
            }

            Category.Name = name;
            Category.Description = description;
            Category.States = states;
            
            _db.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}
