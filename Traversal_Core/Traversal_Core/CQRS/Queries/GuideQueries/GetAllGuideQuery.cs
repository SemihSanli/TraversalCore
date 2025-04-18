using iTextSharp.text;
using MediatR;
using System.Collections.Generic;
using Traversal_Core.CQRS.Results.GuideResults;

namespace Traversal_Core.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery: IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
