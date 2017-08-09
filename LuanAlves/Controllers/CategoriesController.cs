using LuanAlves.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuanAlves.Controllers
{
    public class CategoriesController : Controller
    {
        private static IList<Category> categoryList =
            new List<Category>()
            {
        new Category() { CategoryId = 1, Name = "Keyboard" },
        new Category() { CategoryId = 2, Name = "Monitor" },
        new Category() { CategoryId = 3, Name = "Laptop" },
        new Category() { CategoryId = 4, Name = "Mouse" },
        new Category() { CategoryId = 5, Name = "Printer" },

    };
            
            // GET: Categories
        public ActionResult Index()
        {
            return View(categoryList.OrderBy(c => c.Name));
        }
    }
}