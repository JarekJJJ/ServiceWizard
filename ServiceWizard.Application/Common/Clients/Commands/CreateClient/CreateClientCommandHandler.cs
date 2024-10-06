using MediatR;
using ServiceWizard.Application.Interfaces;
using ServiceWizard.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Commands.CreateClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, int>
    {
        private readonly IServiceWizardDbContext _context;
        public CreateClientCommandHandler(IServiceWizardDbContext serviceWizardDbContext)
        {
            _context = serviceWizardDbContext;
        }
        public async Task<int> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            Client client = new Client
            {
                FirstName = request.Client.FirstName,
                LastName = request.Client.LastName,
                Email = request.Client.Email,
                Phone1 = request.Client.Phone1,
                Phone2 = request.Client.Phone2,
                Address = request.Client.Address,
                City = request.Client.City,
                State = request.Client.State,
                Zip = request.Client.Zip,
                Description = request.Client.Description,
                CreatedBy = "SystemTest" // 
            };
            _context.Clients.Add(client);
            await _context.SaveChangesAsync(cancellationToken);
            return client.Id;
        }
    }
}
