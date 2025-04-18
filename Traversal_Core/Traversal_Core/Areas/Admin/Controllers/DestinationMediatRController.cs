using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Traversal_Core.CQRS.Command.GuideCommands;
using Traversal_Core.CQRS.Queries.GuideQueries;

namespace Traversal_Core.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class DestinationMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public DestinationMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetGuides(int id)
        {
            var values=await _mediator.Send(new GetGuideByIDQuery(id));
            return View(values);
        }
        [HttpGet]
        public IActionResult AddGuides()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuides(CreateGuideCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
