using MediatR;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;

namespace ServiceWizard.Application.Common.Clients.Queries.GetClientsBySearchString;

public class GetClientsBySearchString : IRequest<List<ClientForListVm>>
{
    public string SearchString { get; set; } = "";
}