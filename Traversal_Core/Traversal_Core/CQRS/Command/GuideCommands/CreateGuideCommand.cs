using MediatR;

namespace Traversal_Core.CQRS.Command.GuideCommands
{
    public class CreateGuideCommand:IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
