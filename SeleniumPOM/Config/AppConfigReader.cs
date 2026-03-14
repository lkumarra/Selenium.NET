using Microsoft.Extensions.Configuration;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Setting;
using System.IO;

namespace SeleniumPOM.Config
{
    class AppConfigReader : IConfig
    {
        private readonly IConfiguration _configuration;

        public AppConfigReader()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public string GetBrowser()
        {
            return _configuration[$"AppSettings:{AppConfigKeys.Browser}"];
        }

        public string GetPassword()
        {
            return _configuration[$"AppSettings:{AppConfigKeys.Password}"];
        }

        public string GetUrl()
        {
            return _configuration[$"AppSettings:{AppConfigKeys.Url}"];
        }

        public string GetUserName()
        {
            return _configuration[$"AppSettings:{AppConfigKeys.UserName}"];
        }
    }
}
