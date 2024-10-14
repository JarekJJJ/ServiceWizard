using ServiceWizard.Client.Brokers.API;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;

namespace ServiceWizard.Client.Service.Clients
{
    public class ClientsService: IClientsService
    {
        private readonly IApiBroker _apiBroker;
        public ClientsService(IApiBroker apiBroker)
        {
            _apiBroker = apiBroker;
        }
        public async Task<ListClientForListVm> GetAllClientsAsync(int currentPage, int pageSize)
        {
            var allClients= await _apiBroker.GetAllClientsAsync(currentPage, pageSize);     

            return allClients;
        }
        public async Task<List<ClientForListVm>> GetBySearchStringAsync(string searchString)
        {
            var clients = await _apiBroker.GetBySearchStringAsync(searchString);

            return clients;
        }
        public async Task<ClientForListVm> GetClientViewAsync(int id)
        {
            var client = await _apiBroker.GetClientViewAsync(id);

            return client;
        }
        public async Task EditClientAsync(int id, ClientForListVm client)
        {
            await _apiBroker.EditClientAsync(id, client);
            return;
        }
    }
}
