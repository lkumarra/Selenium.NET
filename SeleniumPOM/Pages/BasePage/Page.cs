using log4net;
using log4net.Repository.Hierarchy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumPOM.Config;
using SeleniumPOM.CustomException;
using SeleniumPOM.Setting;
using SeleniumPOM.Utilities;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumPOM.BasePage
{
    public class Page
    {
        static readonly ILog logger = Log4NetHelper.GetLogger(typeof(Page));
        public static IWebDriver driver = null;

        /// <summary>
        /// Intitialize the Webdriver.
        /// </summary>
        public static void Initialization()
        {
            ObjectRepsitory.config = new AppConfigReader();
            if (ObjectRepsitory.config.GetBrowser().Equals("Chrome"))
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
                logger.Info("Chrome is Launched");
            }
            else if (ObjectRepsitory.config.GetBrowser().Equals("Firefox"))
            {
                new DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
                logger.Info("Firefox is Launched");
            }
            else
            {
                logger.Error("No Suitable Browser is found");
                throw new NoSuitableDriverFound("Suitable Driver Not Found");
            }
            driver.Manage().Cookies.DeleteAllCookies();
            logger.Info("All cookies are deleted");
            driver.Navigate().GoToUrl(ObjectRepsitory.config.GetUrl());
            logger.Info("Url : " + ObjectRepsitory.config.GetUrl() + " is launched");
            driver.Manage().Window.Maximize();
            logger.Info("Window is Maximized");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        /// <summary>
        /// Quit the session .
        /// </summary>
        public static void QuitSession()
        {
            driver.Quit();
            logger.Info("Session is Quit");
        }
    }

}


