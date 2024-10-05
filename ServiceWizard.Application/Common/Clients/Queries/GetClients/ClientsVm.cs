using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Queries.GetClients
{
    public class ClientsVm
    {
        ICollection<ClientDto> Clients { get; set; } = new List<ClientDto>();
    }
}
