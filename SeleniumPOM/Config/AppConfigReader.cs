using SeleniumPOM.Interfaces;
using SeleniumPOM.Setting;
using System.Configuration;


namespace SeleniumPOM.Config
{
    class AppConfigReader : IConfig
    {
        public string GetBrowser()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUrl()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Url);
        }

        public string GetUserName()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.UserName);
        }
    }
}
