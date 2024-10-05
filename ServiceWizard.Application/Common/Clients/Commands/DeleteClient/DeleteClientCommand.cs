using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Commands.DeleteClient
{
    public  class DeleteClientCommand: IRequest
    {
        public int ClientId { get; set; }
    }
}
