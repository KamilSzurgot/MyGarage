using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MyGarage.Blazor.Services;
using System;
using System.Threading.Tasks;

namespace MyGarage.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddOidcAuthentication(options =>
            {
                options.ProviderOptions.Authority = "https://localhost:44333";
                options.ProviderOptions.ClientId = "mygarage";
                options.ProviderOptions.RedirectUri = "https://localhost:44333/authentication/login-callback";
                options.ProviderOptions.PostLogoutRedirectUri = "https://localhost:44333/authentication/logout-callback";
                options.ProviderOptions.DefaultScopes.Add("email");
                options.ProviderOptions.ResponseType = "code";
            });

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(client => client.BaseAddress = new Uri("https://localhost:44381"));
            builder.Services.AddHttpClient<ICountryDataService, CountryDataService>(client => client.BaseAddress = new Uri("https://localhost:44381"));
            builder.Services.AddHttpClient<IJobCategoryDataService, JobCategoryDataService>(client => client.BaseAddress = new Uri("https://localhost:44381"));


            await builder.Build().RunAsync();
        }
    }
}
