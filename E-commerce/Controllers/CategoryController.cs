using E_commerce.Data;
using E_commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categorys = dbContext.Categories.ToList();
            return View(model: categorys);
        }

        public IActionResult Newcategory()
        {
            return View();
        }

        public IActionResult SaveChanges(string CategorieName)
        {
            Category category = new Category { Name = CategorieName };
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
            
            return RedirectToAction("Index"); 


        }
        public IActionResult Edit()
        {
            return View();
        }

    }
}
