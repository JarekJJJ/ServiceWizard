using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceWizard.Application.Interfaces;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Queries.GetClientDetail
{
    public class GetClientDetailQueryHandler : IRequestHandler<GetClientDetailQuery, ClientDetailVm>
    {
        private readonly IServiceWizardDbContext _context;
        public GetClientDetailQueryHandler(IServiceWizardDbContext serviceWizardDbContext )
        {
            _context = serviceWizardDbContext;
        }
        public async Task<ClientDetailVm> Handle(GetClientDetailQuery request, CancellationToken cancellationToken)
        {
           var client = await _context.Clients.Include(p=>p.RepairOrders).Where(x => x.Id == request.ClientId).FirstOrDefaultAsync(cancellationToken);
            if (client != null)
            {
                var lastRepairTitle = client.RepairOrders?.OrderByDescending(x => x.Created).FirstOrDefault()?.Title ?? "Brak napraw";
                var clientVm = new ClientDetailVm
                {
                    FullName = client.FirstName + "" + client.LastName,
                    LastRepairTitle = lastRepairTitle                  
                };
             
                return clientVm;
            }
            else
            {
                var clientVm = new ClientDetailVm
                {
                    FullName = "Client not found",
                    LastRepairTitle = "Client not found"
                };
                return clientVm;
            }  
        }
    }
}
