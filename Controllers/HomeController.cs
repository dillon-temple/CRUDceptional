using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext;

        public HomeController(Context context)
        {
            dbContext = context;
        }
        [HttpGet("/")]
        public IActionResult Index()
        {
            List<Dish> dishes = dbContext.Dishes.ToList();
            return View(dishes);
        }
        [HttpGet("/Add")]
        public IActionResult AddDish()
        {
            return View();
        }

        [HttpPost("NewDish")]
        public IActionResult NewDish(Dish dish)
        {

            dbContext.Add(dish);
            dbContext.SaveChanges();
            int id = dish.Id;

            return Redirect($"/{id}");
        }
        [HttpGet("/edit/{current}")]
        public IActionResult EditDish(int current)
        {
            List<Dish> dish = dbContext.Dishes.Where(u => u.Id == current).ToList();
            Dish pass = dish[0];
            return View(pass);
        }
        [HttpPost("/Update")]
        public IActionResult Update(Dish dish){

            dish.UpdatedAt = DateTime.Now;
            dbContext.Update(dish);
            int id = dish.Id;
            dbContext.SaveChanges();
            
            return Redirect($"/{id}");
        }

        [HttpGet("/delete/{current}")]
        public IActionResult Delete(int current){

            List<Dish> dish = dbContext.Dishes.Where(u => u.Id == current).ToList();
            dbContext.Remove(dish[0]);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet("/{current}")]
        public IActionResult Dish(int current)
        {
            List<Dish> dish = dbContext.Dishes.Where(u => u.Id == current).ToList();
            return View(dish);
        }
    }
}
