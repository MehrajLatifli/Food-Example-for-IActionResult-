using Food__example_for_IActionResult_.Entities;
using Food__example_for_IActionResult_.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;

namespace Food__example_for_IActionResult_.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _env;

        public HomeController(IHostingEnvironment env)
        {
            this._env = env;
        }


        public IActionResult Index()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink{Id = 1, Name ="Drink_1", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/d 1 .png")?.PhysicalPath) },

                new Drink{Id = 2, Name ="Drink_2", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/d 2 .png")?.PhysicalPath) },

                new Drink{Id = 3, Name ="Drink_3", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/d 3 .png")?.PhysicalPath) },

                new Drink{Id = 4, Name ="Drink_4", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/d 4 .png")?.PhysicalPath) },

            };

            List<Hot_meal> hot_meals = new List<Hot_meal>
            {
                new Hot_meal{Id = 1, Name ="Hot_meal_1", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/hm 1 .png")?.PhysicalPath) },

                new Hot_meal{Id = 2, Name ="Hot_meal_2", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/hm 2 .png")?.PhysicalPath) },

                new Hot_meal{Id = 3, Name ="Hot_meal_3", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/hm 3 .png")?.PhysicalPath) },

                new Hot_meal{Id = 4, Name ="Hot_meal_4", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/hm 4 .png")?.PhysicalPath) },

            };

            List<Fast_food> fast_foods = new List<Fast_food>
            {
                new Fast_food{Id = 1, Name ="Fast_food_1", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/ff 1 .png")?.PhysicalPath) },

                new Fast_food{Id = 2, Name ="Fast_food_2", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/ff 2 .png")?.PhysicalPath) },

                new Fast_food{Id = 3, Name ="Fast_food_3", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/ff 3 .png")?.PhysicalPath) },

                new Fast_food{Id = 4, Name ="Fast_food_4", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/ff 4 .png")?.PhysicalPath) },

            };

            var model = new ProductlistViewModel { Drinks = drinks, Hot_meals = hot_meals, Fast_foods = fast_foods };

            return View(model);
        }

        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink{Id = 1, Name ="Drink_1", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/d 1 .png")?.PhysicalPath) },

                new Drink{Id = 2, Name ="Drink_2", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/d 2 .png")?.PhysicalPath) },

                new Drink{Id = 3, Name ="Drink_3", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/d 3 .png")?.PhysicalPath) },

                new Drink{Id = 4, Name ="Drink_4", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/d 4 .png")?.PhysicalPath) },

            };

            return View(drinks);
        }

        public IActionResult Hot_meal()
        {
            List<Hot_meal> hot_meals = new List<Hot_meal>
            {
                new Hot_meal{Id = 1, Name ="Hot_meal_1", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/hm 1 .png")?.PhysicalPath) },

                new Hot_meal{Id = 2, Name ="Hot_meal_2", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/hm 2 .png")?.PhysicalPath) },

                new Hot_meal{Id = 3, Name ="Hot_meal_3", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/hm 3 .png")?.PhysicalPath) },

                new Hot_meal{Id = 4, Name ="Hot_meal_4", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/hm 4 .png")?.PhysicalPath) },

            };

            return View(hot_meals);
        }

        public IActionResult Fast_food()
        {
            List<Fast_food> fast_foods = new List<Fast_food>
            {
                new Fast_food{Id = 1, Name ="Fast_food_1", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/ff 1 .png")?.PhysicalPath) },

                new Fast_food{Id = 2, Name ="Fast_food_2", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/ff 2 .png")?.PhysicalPath) },

                new Fast_food{Id = 3, Name ="Fast_food_3", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/ff 3 .png")?.PhysicalPath) },

                new Fast_food{Id = 4, Name ="Fast_food_4", Image_path=Path.GetFileName(_env.WebRootFileProvider.GetFileInfo("images/ff 4 .png")?.PhysicalPath) },

            };

            return View(fast_foods);
        }
    }
}
