using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceWizard.Application.Common.Clients.Queries.CommonHelpers;
using ServiceWizard.Application.Interfaces;
using ServiceWizard.Domain.Entities;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Queries.GetAllClients
{
    public class GetAllClientsQueryHandler : IRequestHandler<GetAllClientsQuery, ListClientForListVm>
    {
        public readonly IServiceWizardDbContext _context;
        public GetAllClientsQueryHandler(IServiceWizardDbContext serviceWizardDbContext)
        {
            _context = serviceWizardDbContext;
        }

        public async Task<ListClientForListVm> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
        {
            var clients = await _context.Clients.ToListAsync(cancellationToken);
            if (clients != null)
            {
                var clientListVm = new ListClientForListVm();
                clientListVm.TotalClients = clients.Count;
                var clientsToRequest = clients.Skip((request.CurrentPage - 1) * request.PageSize).Take(request.PageSize).ToList();
                clientListVm.ListClients = MapperForClient.MapClientToClientForListVm(clientsToRequest);
                return clientListVm;

            }
            return new ListClientForListVm();
        }
    }
}



