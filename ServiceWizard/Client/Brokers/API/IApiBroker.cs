﻿using ServiceWizard.Shared.Clients.Commands.CreateClient;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;

namespace ServiceWizard.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<ListClientForListVm> GetAllClientsAsync(int currentPage, int pageSize);
        Task<List<ClientForListVm>> GetBySearchStringAsync(string searchString);
        Task<ClientForListVm> GetClientViewAsync(int id);
        Task CreateClientAsync(CreateClientVm clientVm);
        Task EditClientAsync(int id, ClientForListVm client);
    }
}
