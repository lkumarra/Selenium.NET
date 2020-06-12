using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Pages.Locators
{
    class WithdrawalLocator
    {
        [FindsBy(How = How.Name, Using = "accountno")]
        private IWebElement AccountNo { get; set; }

        [FindsBy(How = How.Name, Using = "ammount")]
        private IWebElement Amount { get; set; }

        [FindsBy(How = How.Name, Using = "desc")]
        private IWebElement Description { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='accountno']/following-sibling::label")]
        private IWebElement AccountNumberMessage { get; set; }

        /// <summary>
        /// Return the locator of account number field on Withdrawal Page.
        /// </summary>
        /// <returns>Locator of account number</returns>
        public IWebElement GetAccountNumberLocator()
        {
            return AccountNo;
        }

        /// <summary>
        /// Return the locator of amount field on Withdrawal Page.
        /// </summary>
        /// <returns>Locator of Amount Field</returns>
        public IWebElement GetAmountLocator()
        {
            return Amount;
        }

        /// <summary>
        /// Return the locator of Description field on Withdrawal Page.
        /// </summary>
        /// <returns>Locator of Description Field</returns>
        public IWebElement GetDescriptionLocator()
        {
            return Description;
        }

        /// <summary>
        /// Return the locator of submit button on Withdrawal Page.
        /// </summary>
        /// <returns>Locator of Submit Button</returns>
        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        /// <summary>
        /// Return the locator of Reset Button on Withdrawal Page.
        /// </summary>
        /// <returns>Locator of Reset Button</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }

        /// <summary>
        /// Return the locator of account number message on Withdrawal Page.
        /// </summary>
        /// <returns>Locator of account number message</returns>
        public IWebElement GetAccountNumberMessage()
        {
            return AccountNumberMessage;
        }
    }
}
