using DataAccessLayer.Concrete;
using Traversal_Core.CQRS.Command;

namespace Traversal_Core.CQRS.Handlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.ID);
            values.City = command.City;
            values.DayNight = command.Daynight;
            values.Price= command.Price;
            _context.SaveChanges();
            }
    }
}
