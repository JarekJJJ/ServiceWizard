using MediatR;
using Microsoft.EntityFrameworkCore;
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
    public class GetAllClientsQueryHandler : IRequestHandler<GetAllClientsQuery, List<ClientForListVm>>
    {
        public readonly IServiceWizardDbContext _context;
        public GetAllClientsQueryHandler(IServiceWizardDbContext serviceWizardDbContext)
        {
            _context = serviceWizardDbContext;
        }

        public async Task<List<ClientForListVm>> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
        {
            var clients = await _context.Clients.ToListAsync(cancellationToken);   
            if (clients != null)
            {
                return MapClientsToVm(clients);
            }
            return new List<ClientForListVm>(); 
                }
        private List<ClientForListVm> MapClientsToVm(List<Client> clients)
        {
            var mapedClientToVm = new List<ClientForListVm>();
            foreach (var client in clients)
            {
                var clientVm = new ClientForListVm
                {
                    Id = client.Id,
                    FirstName = client.FirstName,
                    LastName = client.LastName,
                    Email = client.Email,
                    Phone1 = client.Phone1,
                    Phone2 = client.Phone2,
                    Address = client.Address,
                    City = client.City,
                    State = client.State,
                    Zip = client.Zip,
                    Description = client.Description,
                    Created = client.Created,
                    StatusId = client.StatusId
                };
                mapedClientToVm.Add(clientVm);
            }
            return mapedClientToVm;
        }
    }
}



