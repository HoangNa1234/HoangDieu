using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PizzaPlace_2022.Client;
//using PizzaPlace_2022.Client.Services;
using PizzaPlace_2022.Shared;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
builder.Services.AddScoped(sp => new HttpClient 
    { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services
//    .AddTransient<IMenuService, MenuService>();
builder.Services
    .AddTransient<IMenuService, HardCodedMenuService>();
builder.Services
    .AddTransient<IOrderService, ConsoleOrderService>();

await builder.Build().RunAsync();
