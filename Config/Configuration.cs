using Microsoft.Extensions.Configuration;


namespace SpecFlowProjectCoinMarketCap.Config;

public class Configuration
{
    public static class ConfigurationReader
    {
        private static readonly IConfigurationRoot _configuration;

        static ConfigurationReader()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _configuration = builder.Build();
        }

        public static string Get(string key)
        {
            return _configuration[key];
        }
    }

}