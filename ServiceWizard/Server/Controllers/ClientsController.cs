using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceWizard.Application.Common.Clients.Queries.GetClientDetail;

namespace ServiceWizard.Server.Controllers
{
    [Route("api/clients")]
    public class ClientsController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientDetailVm>> GetDetail(int id)
        {

            var vm = await Mediator.Send(new GetClientDetailQuery { ClientId = id });
            return vm;
        }
    }
}
