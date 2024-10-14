using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Shared.Clients.Queries.GetAllClients
{
    public class ListClientForListVm
    {
        public List<ClientForListVm> ListClients { get; set; } = new List<ClientForListVm>();
        public int TotalClients { get; set; }
    }
}
