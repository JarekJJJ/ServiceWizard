using MediatR;
using ServiceWizard.Shared.Clients.Commands.CreateClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Commands.CreateClient
{
    public class CreateClientCommand : IRequest<int>
    {
        public CreateClientVm Client { get; set; }
        public CreateClientCommand(CreateClientVm client)
        {
            Client = client;
        }
    }
}
