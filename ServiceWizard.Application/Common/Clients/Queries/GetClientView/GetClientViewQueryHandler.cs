using MediatR;
using ServiceWizard.Application.Common.Clients.Queries.CommonHelpers;
using ServiceWizard.Application.Interfaces;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Queries.GetClientView
{
    public class GetClientViewQueryHandler : IRequestHandler<GetClientViewQuery, ClientForListVm>
    {
        private readonly IServiceWizardDbContext _context;
        public GetClientViewQueryHandler(IServiceWizardDbContext serviceWizardDbContext)
        {
            _context = serviceWizardDbContext;
        }

        public Task<ClientForListVm> Handle(GetClientViewQuery request, CancellationToken cancellationToken)
        {
            var client = _context.Clients.Where(x => x.Id == request.ClientId).FirstOrDefault();
            if (client != null)
            {
                var result = MapperForClient.MapClientToClientForListVm(client);
                return Task.FromResult(result);
            }
            else
            {
                var clientVm = new ClientForListVm
                {
                    Id = 0,
                    FirstName = "Client not found",
                    LastName = "Client not found"
                };
                return Task.FromResult(clientVm);

            }
        }
    }
}
