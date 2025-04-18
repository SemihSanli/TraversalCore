using DataAccessLayer.Concrete;
using Traversal_Core.CQRS.Command;

namespace Traversal_Core.CQRS.Handlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;

        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.id);
            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}
