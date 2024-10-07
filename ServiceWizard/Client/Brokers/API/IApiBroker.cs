using ServiceWizard.Shared.Clients.Commands.CreateClient;

namespace ServiceWizard.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<T> GetAsync<T>(string apiUrl);
        Task CreateClientAsync(CreateClientVm clientVm);
    }
}
