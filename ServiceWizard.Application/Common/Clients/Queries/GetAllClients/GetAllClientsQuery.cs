using MediatR;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;

namespace ServiceWizard.Application.Common.Clients.Queries.GetAllClients
{
    public class GetAllClientsQuery : IRequest<ListClientForListVm>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }
}