using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labset_1.Models;
using Labset_1.Data;

namespace Labset_1.Controllers
{
    public class PostsController : Controller
    {
        #region Dependency Injection

        private readonly BlogDataContext _db;
        public PostsController(BlogDataContext db)
        {
            _db = db;
        }

        #endregion

        #region Index

        public IActionResult Index()
        {
            //IEnumerable<Post> posts = _db.Posts.ToArray();
            IEnumerable<Post> mostrecentposts = _db.Posts.OrderByDescending(x =>
           x.PostedDate).Take(5).ToArray();
            return View(mostrecentposts);
        }

        #endregion

        #region GET: Create Post View
        // GET Create View
        public IActionResult Create()
        {
            return View();
        }

        #endregion

        #region POST: Create Post
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
            _db.Posts.Add(post);
            _db.SaveChanges();

            return RedirectToAction("Post", new { id = post.PostID });
        }

        #endregion

        #region GET: Details but called Post
        public IActionResult Post(string id)
        {
            var post = _db.Posts.FirstOrDefault(m => m.PostID == id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        #endregion
    }
}
