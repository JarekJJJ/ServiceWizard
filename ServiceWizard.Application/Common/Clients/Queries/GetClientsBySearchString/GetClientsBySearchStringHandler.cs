using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceWizard.Application.Common.Clients.Queries.CommonHelpers;
using ServiceWizard.Application.Interfaces;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Queries.GetClientsBySearchString
{
    public class GetClientsBySearchStringHandler : IRequestHandler<GetClientsBySearchString, List<ClientForListVm>>
    {

        public readonly IServiceWizardDbContext _context;
        public GetClientsBySearchStringHandler(IServiceWizardDbContext serviceWizardDbContext)
        {
            _context = serviceWizardDbContext;
        }

        public async Task<List<ClientForListVm>> Handle(GetClientsBySearchString request, CancellationToken cancellationToken)
        {
            var clients = await _context.Clients.ToListAsync(cancellationToken);
            var filteredClients = clients.Where(client =>
            client.GetType().GetProperties().Any(prop =>
            {
                var value = prop.GetValue(client)?.ToString();
                return value != null && value.Contains(request.SearchString, StringComparison.OrdinalIgnoreCase);
            })).ToList();

            return MapperForClient.MapClientToClientForListVm(filteredClients);
        }
    }
}
