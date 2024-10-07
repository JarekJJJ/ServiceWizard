using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceWizard.Application.Common.Clients.Commands.CreateClient;
using ServiceWizard.Application.Common.Clients.Queries.GetClientDetail;
using ServiceWizard.Shared.Clients.Commands.CreateClient;

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
        [HttpPost("create")]
        public async Task<ActionResult> CreateClient([FromBody] CreateClientVm clientVm)
        {
            var command = new CreateClientCommand(clientVm);
           var clientId = await Mediator.Send(command);
            return Ok(clientId);
        }
    }
}
