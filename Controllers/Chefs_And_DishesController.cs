using Microsoft.EntityFrameworkCore;
using chef_and_dishes.Models;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace chef_and_dishes.Controllers
{
    public class Chefs_And_DishesController : Controller
    {
        private MyContext dbContext;
        // here we can "inject" our context service into the constructor
        public Chefs_And_DishesController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult AllChefs()
        {
            List<Chef> AllChefsWDishes = dbContext.Chefs
            .Include(chef => chef.CreatedDishes)
            .ToList();
            return View(AllChefsWDishes);
        }
        [HttpGet("dishes")]
        public IActionResult AllDishes()
        {
            List<Dish> AllDishesWChefs = dbContext.Dishes
            .Include(dish => dish.Creater)
            .ToList();
            return View(AllDishesWChefs);
        }

        [HttpGet("new")]
        public IActionResult NewChefView()
        {
            return View();
        }

        [HttpPost("newchef")]
        public IActionResult NewChef(Chef newChef)
        {
            Console.WriteLine("NewChef");
            if(ModelState.IsValid)
            {
                dbContext.Chefs.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("AllChefs");
            }
            else
            {
                return View("NewChefView");
            }
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDishView()
        {
            List<Chef> AllChefs = dbContext.Chefs.ToList();
            ViewBag.AllChefs = AllChefs;
            return View();
        }
        [HttpPost("dishes/newdish")]
        public IActionResult NewDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                Chef chefInQuestion = dbContext.Chefs.FirstOrDefault(c => c.ChefId == newDish.ChefId);
                newDish.Creater = chefInQuestion;
                dbContext.Dishes.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("AllDishes");
            }
            else{
                return View("NewDishView");
            }
        }
    }
}
