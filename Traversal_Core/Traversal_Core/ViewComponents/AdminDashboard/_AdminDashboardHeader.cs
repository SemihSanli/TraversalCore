using Microsoft.AspNetCore.Mvc;

namespace Traversal_Core.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeader : ViewComponent
    {
         
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

