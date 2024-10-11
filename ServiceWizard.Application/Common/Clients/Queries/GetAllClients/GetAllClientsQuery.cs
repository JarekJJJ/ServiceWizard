using MediatR;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;

namespace ServiceWizard.Application.Common.Clients.Queries.GetAllClients
{
    public class GetAllClientsQuery : IRequest<List<ClientForListVm>>
    {
    }
}