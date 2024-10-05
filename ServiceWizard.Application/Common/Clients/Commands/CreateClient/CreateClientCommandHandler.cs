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
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone1 = request.Phone1
            };
            _context.Clients.Add(client);
            await _context.SaveChangesAsync(cancellationToken);
            return client.Id;
        }
    }
}
