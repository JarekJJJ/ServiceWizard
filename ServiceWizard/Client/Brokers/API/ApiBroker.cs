
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
        public async Task<T> GetAsync<T>(string apiUrl) =>
            await _httpClient.GetFromJsonAsync<T>(apiUrl);


        public async Task CreateClientAsync<T>(string apiUrl, T modelVm) =>
            await _httpClient.PostAsJsonAsync<T>(apiUrl, modelVm);
    }
}
