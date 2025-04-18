using Microsoft.AspNetCore.SignalR;
using SignalRAPI.Model;
using System.Threading.Tasks;

namespace SignalRAPI.Hubs
{
    public class VisitorHub:Hub
    {
        private readonly VisitorService visitorService;

        public VisitorHub(VisitorService visitorService)
        {
            this.visitorService = visitorService;
        }
        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("CallVisitList", "bbb");
        }
    }
}
