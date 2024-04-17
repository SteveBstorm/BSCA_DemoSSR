using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Tools;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
//builder.Services.AddScoped<Bidule>();
await builder.Build().RunAsync();
