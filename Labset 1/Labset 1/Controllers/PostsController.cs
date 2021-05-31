using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labset_1.Models;

namespace Labset_1.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Get: Create Post View
        // GET Create View
        public IActionResult Create()
        {
            return View();
        }

        #endregion

        #region Post: Create Post
        // Post Create Post
        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }
            post.PostedDate = DateTime.Now;
            post.Author = User.Identity.Name;

            return View();
        }

        #endregion


        #region Post
        public IActionResult Post(int id)
        {
            Post post = new Post();
            post.Title = "My Blog Post";
            post.PostedDate = DateTime.Now;
            post.Author = "Sam Zhao";
            post.Body = "This is my first blogpost";
            return View(post);
        }

        #endregion
    }
}
