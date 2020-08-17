using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsApp.Models;
using NewsApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace NewsApp.Controllers
{
    public class HomeController : Controller
    {
        
        NewsContext db;
        public HomeController(NewsContext context)
        {
            this.db = context;
        }

        public IActionResult Index()
        {
            var result=db.Categories.ToList();
            return View(result);
        }

        [Authorize]
        public IActionResult News(int id)
        {
            
            Category c = db.Categories.Find(id);
            //ViewData["Cat"] = c.Name;--dictionary
            ViewBag.Cat = c.Name;//dynamic object
            var result= db.News.Where(x => x.CategoryId == id).OrderByDescending(y=>y.Date).ToList();
            return View(result );
        }
        //Search
        public IActionResult Search(string term)
        {

            var result = db.Categories.Include(a => a.News).Where(b => b.Name.Contains(term)
               || b.Description.Contains(term)).ToList();
            return View(result);
        }
        public IActionResult DeleteNews(int id)
        {
            var News = db.News.Find(id);
            db.News.Remove(News);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Team()
        {
            return View(db.Teammembers.ToList());
        }

        [HttpPost]
        public IActionResult SaveContact(ContactUS model)
        {
            if(ModelState.IsValid) {

            db.Contacts.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View("Contact", model);
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Messages()
        {
           
            return View(db.Contacts.ToList());
        }
       
            public IActionResult Privacy()
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
