using Microsoft.AspNetCore.Mvc;

namespace Traversal_Core.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {

            return View();
        }
    }
}
