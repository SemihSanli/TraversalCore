using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Core.Areas.Member.Controllers
{
    public class CommentController : Controller
    {
        [AllowAnonymous]
        [Area("Member")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
