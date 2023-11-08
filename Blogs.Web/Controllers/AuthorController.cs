using Blogs.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
using Blogs.Domain.InputModels;

namespace Blogs.Web.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _service;

        public AuthorController(IAuthorService service) {
            this._service = service;
        }

        public IActionResult Index()
        {
            return View(new NewAuthor());
        }

        [HttpPost]
        public IActionResult Index(NewAuthor newAuthor)
        {
            if (ModelState.IsValid)
            {
                if (!_service.Insert(newAuthor))
                {
                    ModelState.AddModelError(string.Empty, "Author could'n be inserted");
                }
                else
                {
                
                    return RedirectToAction("Insert", "Posts");
                }
            }
            return View(new NewAuthor());

        }
    }
}
