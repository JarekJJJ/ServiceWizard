using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceWizard.Application.Common.Clients.Queries.CommonHelpers;
using ServiceWizard.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Commands.UpdateClient
{
    public class EditClientCommandHandler : IRequestHandler<EditClientCommand>
    {
        private readonly IServiceWizardDbContext _context;
        public EditClientCommandHandler(IServiceWizardDbContext serviceWizardDbContext)
        {
            _context = serviceWizardDbContext;
        }
        public async Task<Unit> Handle(EditClientCommand request, CancellationToken cancellationToken)
        {
            var client = await _context.Clients.Where(x => x.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            _context.Clients.Update(MapperForClient.MapClientForListVmToClient(request.Client, client));
           await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
