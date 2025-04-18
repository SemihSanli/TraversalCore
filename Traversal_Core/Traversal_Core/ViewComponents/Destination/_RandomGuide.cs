using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Core.ViewComponents.Destination
{
    public class _RandomGuide:ViewComponent
    {
        private readonly IGuideService _guideService;

        public _RandomGuide(IGuideService guideService)
        {
            _guideService = guideService;
        }
        public IViewComponentResult Invoke()
        {
            var values=_guideService.TGetByID(1);
            return View(values);    
        }
    }
}
