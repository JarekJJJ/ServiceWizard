using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceWizard.Application.Common.Clients.Commands.CreateClient;
using ServiceWizard.Application.Common.Clients.Queries.GetAllClients;
using ServiceWizard.Application.Common.Clients.Queries.GetClientDetail;
using ServiceWizard.Shared.Clients.Commands.CreateClient;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;

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
        [HttpGet("get/all")]
        public async Task<ActionResult<List<ClientForListVm>>> GetAllAsync()
        {
            var vm = await Mediator.Send(new GetAllClientsQuery());
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
