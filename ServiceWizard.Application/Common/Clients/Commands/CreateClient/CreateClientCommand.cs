using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Commands.CreateClient
{
    public class CreateClientCommand: IRequest<int>
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone1 { get; set; }
    }
}
