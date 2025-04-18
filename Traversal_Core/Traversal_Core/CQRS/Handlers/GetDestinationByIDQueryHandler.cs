using DataAccessLayer.Concrete;
using Traversal_Core.CQRS.Queries;
using Traversal_Core.CQRS.Results;

namespace Traversal_Core.CQRS.Handlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery getDestinationByIDQuery)
        {
            var values=_context.Destinations.Find(getDestinationByIDQuery.id);
            return new GetDestinationByIDQueryResult
            {
                ID = values.DestinationID,
                City = values.City,
                Daynight = values.DayNight,
                Price = values.Price
            };
        }
    }
}
