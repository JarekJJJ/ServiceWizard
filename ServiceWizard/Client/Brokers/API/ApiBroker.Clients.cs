using ServiceWizard.Shared.Clients.Commands.CreateClient;

namespace ServiceWizard.Client.Brokers.API
{
    public partial class ApiBroker
    {
        //get dodać do interfejsu po dodaniu metody
        public async Task CreateClientAsync(CreateClientVm clientVm)
        {
            await this.CreateClientAsync<CreateClientVm>("api/clients/create", clientVm);
        }
    }
}
