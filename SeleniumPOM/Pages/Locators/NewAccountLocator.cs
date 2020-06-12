using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Pages.Locators
{
    class NewAccountLocator
    {
        [FindsBy(How = How.Name, Using = "cusid")]
        private IWebElement CustomerID { get; set; }

        [FindsBy(How = How.Name, Using = "selaccount")]
        private IWebElement AccountType { get; set; }

        [FindsBy(How = How.Name, Using = "inideposit")]
        private IWebElement InitialDeposit { get; set; }

        [FindsBy(How = How.Name, Using = "button2")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "reset")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='cusid']/following-sibling::label")]
        private IWebElement CustomerIdMessage { get; set; }

        /// <summary>
        /// Return the locator of CustomerID field on New Account Page.
        /// </summary>
        /// <returns>Locator of Customer ID</returns>
        public IWebElement GetCustomerIDLocator()
        {
            return CustomerID;
        }

        /// <summary>
        /// Return the locator of AccountType Dropdown.
        /// </summary>
        /// <returns>Locator of AccontType DropDown</returns>
        public IWebElement GetAccountTypeLocator()
        {
            return AccountType;
        }

        /// <summary>
        /// Return the locator of InitialDeposit field on New Customer Page.
        /// </summary>
        /// <returns>Locator of InitialDeposit field</returns>
        public IWebElement GetInitialDepositLocator()
        {
            return InitialDeposit;
        }

        /// <summary>
        /// Return the locator of SubmitButton on New Customer Page.
        /// </summary>
        /// <returns>Locator of Submit Button</returns>
        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        /// <summary>
        /// Return the locator of ResetButton on New Customer Page.
        /// </summary>
        /// <returns>Locator of Submit Button</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }

        /// <summary>
        /// Return the locator of CustomerID Message on NewCustomer Page.
        /// </summary>
        /// <returns>Locator of CustomerID Message</returns>
        public IWebElement GetCustomerIDMessageLocator()
        {
            return CustomerIdMessage;
        }
    }
}
