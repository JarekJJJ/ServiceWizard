using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Queries.GetClients
{
    public class ClientDto
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
    }
}
