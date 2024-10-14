
using ServiceWizard.Shared.Clients.Queries.GetAllClients;
using System.Net.Http.Json;

namespace ServiceWizard.Client.Brokers.API
{
    public partial class ApiBroker : IApiBroker
    {
        private readonly HttpClient _httpClient;
        public ApiBroker(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<T> GetAllClientsAsync<T>(string apiUrl,int currentPage,int pageSize)
        {
            var url = $"{apiUrl}?currentPage={currentPage}&pageSize={pageSize}";
            return await _httpClient.GetFromJsonAsync<T>(url);
        }

        public async Task<T> GetBySearchStringAsync<T>(string apiUrl, string searchString)
        {
            var url = $"{apiUrl}?searchString={searchString}";
            return await _httpClient.GetFromJsonAsync<T>(url);

        }
        public async Task<T> GetClientViewAsync<T>(string apiUrl, int id)
        {
            var url = $"{apiUrl}/{id}";
            return await _httpClient.GetFromJsonAsync<T>(url);
        }
        public async Task EditClientAsync<T>(int id, T modelVm) =>
            await _httpClient.PutAsJsonAsync<T>($"api/clients/edit/{id}", modelVm);

        public async Task CreateClientAsync<T>(string apiUrl, T modelVm) =>
            await _httpClient.PostAsJsonAsync<T>(apiUrl, modelVm);

    }
}
