using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labset_1.Models;

namespace Labset_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post(int id)
        {
            Post post = new Post();
            post.Title = "My Blog Post";
            post.PostedDate = DateTime.Now;
            post.Author = "Sam Zhao";
            post.Body = "This is my first blogpost";
            return View(post);
        }
    }
}
