using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Queries.GetClientDetail
{
    public class GetClientDetailQuery: IRequest<ClientDetailVm> 
    {
        public int ClientId { get; set; }
    }
}
