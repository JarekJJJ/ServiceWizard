using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceWizard.Domain.Entities;
using ServiceWizard.Shared.Clients.Commands.CreateClient;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Application.Common.Clients.Queries.CommonHelpers
{
    public static class MapperForClient
    {
        public static ClientForListVm MapClientToClientForListVm(Client client)
        {
            return new ClientForListVm
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Description = client.Description,
                Address = client.Address,
                City = client.City,
                State = client.State,
                Zip = client.Zip,
                Phone1 = client.Phone1,
                Phone2 = client.Phone2,
                Email = client.Email,
                Created = client.Created,
                StatusId = client.StatusId
            };
        }
        public static Client MapClientForListVmToClient(ClientForListVm createClientVm, Client client)
        {

            if (client != null)
            {
                client.FirstName = createClientVm.FirstName;
                client.LastName = createClientVm.LastName;
                client.Description = createClientVm.Description;
                client.Address = createClientVm.Address;
                client.City = createClientVm.City;
                client.State = createClientVm.State;
                client.Zip = createClientVm.Zip;
                client.Phone1 = createClientVm.Phone1;
                client.Phone2 = createClientVm.Phone2;
                client.Email = createClientVm.Email;
               // client.Created = createClientVm.Created;
                client.StatusId = createClientVm.StatusId;
                return client;
            }

                return new Client();

        }
        public static List<ClientForListVm> MapClientToClientForListVm(List<Client> clients)
        {
            List<ClientForListVm> listClientVm = new List<ClientForListVm>();
            foreach (var client in clients)
            {
                listClientVm.Add(MapClientToClientForListVm(client));
            }
           
            return listClientVm;
        }

    }
}
