using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceWizard.Application.Common.Clients.Commands.CreateClient;
using ServiceWizard.Application.Common.Clients.Commands.UpdateClient;
using ServiceWizard.Application.Common.Clients.Queries.GetAllClients;
using ServiceWizard.Application.Common.Clients.Queries.GetClientDetail;
using ServiceWizard.Application.Common.Clients.Queries.GetClientsBySearchString;
using ServiceWizard.Application.Common.Clients.Queries.GetClientView;
using ServiceWizard.Shared.Clients.Commands.CreateClient;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;

namespace ServiceWizard.Server.Controllers
{
    [Route("api/clients")]
    public class ClientsController : BaseController
    {
        [HttpGet("/detail/{id}")]
        public async Task<ActionResult<ClientDetailVm>> GetDetail(int id)
        {
            var vm = await Mediator.Send(new GetClientDetailQuery { ClientId = id });
            return vm;
        }
        [HttpGet("view/{id}")]
        public async Task<ActionResult<ClientForListVm>> GetClientView(int id)
        {
            var vm = await Mediator.Send(new GetClientViewQuery { ClientId = id });
            return vm;
        }
        [HttpGet("get/all")]
        public async Task<ActionResult<ListClientForListVm>> GetAllAsync(int currentPage, int pageSize)
        {
            var vm = await Mediator.Send(new GetAllClientsQuery { CurrentPage = currentPage, PageSize = pageSize });
            // var vm = await Mediator.Send(new GetAllClientsQuery());
            return vm;
        }
        [HttpGet("get/search")]
        public async Task<ActionResult<List<ClientForListVm>>> GetBySearchString([FromQuery] string searchString)
        {
            var vm = await Mediator.Send(new GetClientsBySearchString { SearchString = searchString });
            return vm;
        }

        [HttpPost("create")]
        public async Task<ActionResult> CreateClient([FromBody] CreateClientVm clientVm)
        {
            var command = new CreateClientCommand(clientVm);
           var clientId = await Mediator.Send(command);
            return Ok(clientId);
        }
        [HttpPut("edit/{id}")]
        public async Task<ActionResult> EditClient(int id, [FromBody] ClientForListVm client)
        {
            var command = new EditClientCommand(id, client);
            await Mediator.Send(command);
            return Ok();
        }
    }
}
