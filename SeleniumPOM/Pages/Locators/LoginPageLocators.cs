using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Pages.Locators
{
    class LoginPageLocators
    {

        [FindsBy(How = How.Name, Using ="uid")]
        private IWebElement UserID { get; set; }

        [FindsBy(How = How.Name, Using ="password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "btnLogin")]
        private IWebElement LoginButton { get; set; }

        [FindsBy(How = How.Name, Using = "btnReset")]
        private IWebElement ResetButton { get; set; }

        public IWebElement GetUserIDLocator()
        {
            return this.UserID;
        }

        public IWebElement GetPasswordLocator()
        {
            return this.Password;
        }

        public IWebElement GetLoginButtonLocator()
        {
            return this.LoginButton;
        }

        public IWebElement GetResetButtonLocator()
        {
            return this.ResetButton;
        }

    }
}
