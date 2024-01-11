using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using MudBlazor.Services;
using System.Globalization;
using TIN_Project.Client;
using TIN_Project.Client.Services;
using TIN_Project.Shared.Base64Decoder;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddLocalization();
builder.Services.AddMudServices();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddSingleton<IDecoder, Decoder>();
builder.Services.AddScoped<IAlertService, AlertService>();
builder.Services.AddScoped<AuthenticationStateProvider, UserAuthenticationStateProvider>();
builder.Services.AddHttpClient("TIN_Project.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("TIN_Project.ServerAPI"));

builder.Services.AddBlazoredLocalStorage();
var host = builder.Build();

CultureInfo culture;
var localStorage = host.Services.GetRequiredService<ILocalStorageService>();
var result = await localStorage.GetItemAsStringAsync("culture");

if (result != null)
{
    culture = new CultureInfo(result);
}
else
{
    culture = new CultureInfo("en-US");
    await localStorage.SetItemAsStringAsync("culture", "en-US");
}

CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

await host.RunAsync();
