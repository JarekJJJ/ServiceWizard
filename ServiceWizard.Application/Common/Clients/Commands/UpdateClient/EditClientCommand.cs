using MediatR;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Commands.UpdateClient
{
    public class EditClientCommand : IRequest
    {
        public int Id { get; set; }
        public ClientForListVm Client { get; set; }
        public EditClientCommand(int id, ClientForListVm client)
        {
            Id = id;
            Client = client;
        }
    }
}
