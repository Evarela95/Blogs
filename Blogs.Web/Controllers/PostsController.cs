using Blogs.Application.Contracts;
using Blogs.Domain.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace Blogs.Web.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostService _pservice;

        public PostsController(IPostService pservice)
        {
            this._pservice = pservice;
        }

        public IActionResult Index()
        {
            var posts = _pservice.List();
            return View(posts);
        }


        public IActionResult Insert()
        {
            return View(new NewPost());
        }

        [HttpPost]
        public IActionResult Insert(NewPost newPost)
        {
            if (ModelState.IsValid)
            {
                if (!_pservice.Insert(newPost))
                {
                    ModelState.AddModelError(string.Empty, "Post could'n be inserted");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View(new NewPost());

        }



    }
}
