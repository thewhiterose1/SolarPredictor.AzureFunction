using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

[assembly: FunctionsStartup(typeof(SolarPredictor.Startup))]

namespace SolarPredictor
{
    class Startup : FunctionsStartup
    {
        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
            string cs = Environment.GetEnvironmentVariable("APPCONFIG_CONNECTION");

            if (!string.IsNullOrEmpty(cs))
            {
                builder.ConfigurationBuilder.AddAzureAppConfiguration(cs);
            }
        }

        public override void Configure(IFunctionsHostBuilder builder)
        {

        }
    }
}