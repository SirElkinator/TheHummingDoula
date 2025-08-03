using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TheHummingDoula;
using MudBlazor.Services;
using MudBlazor;
using MudBlazor.ThemeManager;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://sirelkinator.github.io/TheHummingDoula/") });
builder.Services.AddMudServices();
await builder.Build().RunAsync();
