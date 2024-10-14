using MediatR;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Queries.GetClientView
{
    public class GetClientViewQuery: IRequest<ClientForListVm>
    {
        public int ClientId { get; set; }

    }
}
