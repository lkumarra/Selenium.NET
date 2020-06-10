using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumPOM.Config;
using SeleniumPOM.CustomException;
using SeleniumPOM.Setting;
using System;

namespace SeleniumPOM.TestBase
{
    public class Page
    {

        public static IWebDriver driver = null;

        /// <summary>
        /// Intitialize the Webdriver.
        /// </summary>
        public static void Initialization()
        {
            ObjectRepsitory.config = new AppConfigReader();
            if (ObjectRepsitory.config.GetBrowser().Equals("Chrome"))
            {
                driver = new ChromeDriver();

            }
            else if (ObjectRepsitory.config.GetBrowser().Equals("Firefox"))
            {
                driver = new FirefoxDriver();
            }
            else
            {
                throw new NoSuitableDriverFound("Suitable Driver Not Found");
            }
            driver.Navigate().GoToUrl(ObjectRepsitory.config.GetUrl());
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Cookies.DeleteAllCookies();
        }

        /// <summary>
        /// Quit the session .
        /// </summary>
        public static void QuitSession()
        {
            driver.Quit();
        }
    }

}


