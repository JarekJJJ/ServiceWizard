using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceWizard.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Commands.DeleteClient
{
    public class DeleteClientCommandHandler: IRequestHandler<DeleteClientCommand>
    {
        private readonly IServiceWizardDbContext _context;
        public DeleteClientCommandHandler( IServiceWizardDbContext serviceWizardDbContext)
        {
            _context = serviceWizardDbContext;
        }

        public async Task<Unit> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            var client = await _context.Clients.Where(x => x.Id == request.ClientId).FirstOrDefaultAsync(cancellationToken);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync(cancellationToken);
            }
            return Unit.Value;
        }

    
    }
}
