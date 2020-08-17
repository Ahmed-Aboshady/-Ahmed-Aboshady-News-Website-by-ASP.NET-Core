using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsApp.Data;

namespace NewsApp.Areas.Admin.Controllers
{
    [Area("Admin")]   
    public class DefaultController : Controller
    {
        NewsContext db;
        public DefaultController(NewsContext context)
        {
            db = context;
        } 
        public IActionResult Index()
        {
            int teamcount= db.Teammembers.Count();
            int Newscount = db.News.Count();
            int Contactcount = db.Contacts.Count();
            int Catcount = db.Categories.Count();
            var result = new Admin
            {
                team = teamcount,
                news = Newscount,
                contact = Contactcount,
                cats = Catcount
            };
            return View(result);
        }
    }
    public class Admin
    {
        public int contact { get; set; }
        public int team { get; set; }
        public int news { get; set; }
        public int cats { get; set; }
    }
}
