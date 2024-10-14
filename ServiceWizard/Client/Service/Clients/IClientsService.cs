using ServiceWizard.Shared.Clients.Queries.GetAllClients;

namespace ServiceWizard.Client.Service.Clients
{
    public interface IClientsService
    {
        Task<ListClientForListVm> GetAllClientsAsync(int currentPage, int pageSize);
        Task<List<ClientForListVm>> GetBySearchStringAsync(string searchString);
        Task<ClientForListVm> GetClientViewAsync(int id);
        Task EditClientAsync(int id, ClientForListVm client);
    }
}