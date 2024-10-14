using ServiceWizard.Shared.Clients.Commands.CreateClient;
using ServiceWizard.Shared.Clients.Queries.GetAllClients;

namespace ServiceWizard.Client.Brokers.API
{
    public partial class ApiBroker
    {
        //get dodać do interfejsu po dodaniu metody
        public async Task<ListClientForListVm> GetAllClientsAsync(int currentPage, int pageSize) //get
        {
            var apiUrl = await this.GetAllClientsAsync<ListClientForListVm>("api/clients/get/all", currentPage, pageSize);
            return apiUrl;
        }
        public async Task<List<ClientForListVm>> GetBySearchStringAsync(string searchString)
        {
            var apiUrl = await this.GetBySearchStringAsync<List<ClientForListVm>>("api/clients/get/search", searchString);
            return apiUrl;
        }
        public async Task<ClientForListVm> GetClientViewAsync(int id) //get
        {
            var apiUrl = await this.GetClientViewAsync<ClientForListVm>("api/clients/view", id);
            return apiUrl;
        }
        public async Task CreateClientAsync(CreateClientVm clientVm) //post
        {
            await this.CreateClientAsync<CreateClientVm>("api/clients/create", clientVm);
        }
        public async Task EditClientAsync(int id, ClientForListVm client) //put
        {
            await this.EditClientAsync<ClientForListVm>(id, client);
        }
    }
}
