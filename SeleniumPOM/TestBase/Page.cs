using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.TestBase
{
    public class Page
    {

     public static IWebDriver driver = null;

     public static void Initialization()
        {
            if (Constants.BrowserName.Equals("Chrome"))
            {
                driver = new ChromeDriver();

               } else if (Constants.BrowserName.Equals("Firefox"))
            {
                driver = new FirefoxDriver();
            }
            driver.Navigate().GoToUrl(Constants.Url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Cookies.DeleteAllCookies();
        }

        public static void QuitSession()
        {
            driver.Quit();
        }
    }

}

  
