using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Pages.Locators
{
    class FundTrasferLocator
    {

        [FindsBy(How = How.Name, Using = "payersaccount")]
        private IWebElement PayersAccNo { get; set; }

        [FindsBy(How = How.Name, Using = "payeeaccount")]
        private IWebElement PayeesAccNo { get; set; }

        [FindsBy(How = How.Name, Using = "ammount")]
        private IWebElement Amount { get; set; }

        [FindsBy(How = How.Name, Using = "desc")]
        private IWebElement Description { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='payersaccount']/following-sibling::label")]
        private IWebElement PayersAccountMessage { get; set; }

        /// <summary>
        /// Return the locator of Payers Account Number field on Fund Transfer Page.
        /// </summary>
        /// <returns>Locator of Payers Account Number Field</returns>
        public IWebElement GetPayersAccNoLocator()
        {
            return PayersAccNo;
        }

        /// <summary>
        /// Return the locator of Payees Account Number field on Fund Transfer Page.
        /// </summary>
        /// <returns>Locator of Payess Account Number field</returns>
        public IWebElement GetPayessAccNoLocator()
        {
            return PayeesAccNo;
        }

        /// <summary>
        /// Return the locator of Amount Field on Fund Transfer Page.
        /// </summary>
        /// <returns>Locator of Amount field</returns>
        public IWebElement GetAmountLocator()
        {
            return Amount;
        }

        /// <summary>
        /// Return the locator of Description Field on Fund Transfer Page.
        /// </summary>
        /// <returns>Locator of Description field</returns>
        public IWebElement GetDescriptionLocator()
        {
            return Description;
        }

        /// <summary>
        /// Return the locator of Submit Button on Fund Transfer Page.
        /// </summary>
        /// <returns>Locator of Submit Button</returns>
        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        /// <summary>
        /// Return the locator of Reset Button on Fund Transfer Page.
        /// </summary>
        /// <returns>Locator of Reset Button</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }

        /// <summary>
        /// Return the locator of PayersAccount Number Message.
        /// </summary>
        /// <returns>Payers Account Number Message</returns>
        public IWebElement GetPayersAccountMessageLocator()
        {
            return PayersAccountMessage;
        }
    }
}
