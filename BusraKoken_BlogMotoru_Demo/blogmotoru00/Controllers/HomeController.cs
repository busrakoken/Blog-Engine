using BlogMotoru00.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMotoru00.Controllers
{
    public class HomeController : Controller
    {
        Entities dB = new Entities();
        public ActionResult Index()
        {

            var posts= Posts(3);
            return View(posts);
        }

        public List<Post> Posts(int count)
        {
            return dB.Posts.OrderByDescending(a => a.Date).Take(count).ToList();
        
        }

        public ActionResult CPosts(int Cid)
        {
            var posts= dB.Posts.Where(p => p.CategoryId == Cid).ToList();
            return View(posts);
        
        }

        

    }
}
