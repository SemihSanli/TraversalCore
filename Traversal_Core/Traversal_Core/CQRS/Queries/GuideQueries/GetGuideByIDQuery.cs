using MediatR;
using Traversal_Core.CQRS.Results.GuideResults;

namespace Traversal_Core.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery : IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int id) 
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
