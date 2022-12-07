using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using CPSC481_Prototype;
using CPSC481_Prototype.Persistence;
using CPSC481_Prototype.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazorise(o => o.Immediate = true).AddBootstrapProviders().AddFontAwesomeIcons();
builder.Services.AddSingleton<LibraryItemStore>();
builder.Services.AddSingleton<UserStore>();
builder.Services.AddSingleton<LoginService>();

await builder.Build().RunAsync();
