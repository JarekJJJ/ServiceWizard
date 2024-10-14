using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ServiceWizard.Client;
using ServiceWizard.Client.Brokers.API;
using ServiceWizard.Client.Service;
using ServiceWizard.Client.Service.Clients;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IApiBroker, ApiBroker>();
builder.Services.AddTransient<ITestService, TestService>();
builder.Services.AddTransient<IClientsService, ClientsService>();
await builder.Build().RunAsync();
