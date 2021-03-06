﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class DeleteCustomerLocator
    {
        #region PageFactory 

        [FindsBy(How = How.Name, Using = "cusid")]
        private IWebElement CustomerID { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@id, 'message')]")]
        private IWebElement CustomerIDMessage { get; set; }

        #endregion

        #region GetterMethods

        /// <summary>
        /// Return the locator of CustomerID Field on DeleteCustomer Page.
        /// </summary>
        /// <returns>Locator of CustomerID</returns>
        public IWebElement GetCustomerIDLocator()
        {
            return CustomerID;
        }

        /// <summary>
        /// Return the locator of SubmitButton on DeleteCustomer Page.
        /// </summary>
        /// <returns>Locator of SubmitButton</returns>
        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        /// <summary>
        /// Return the Locator of ResetButton on DeleteCustomer Page.
        /// </summary>
        /// <returns>Locator of SubmitButton</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }

        /// <summary>
        /// Return the locator of custoemr id message
        /// </summary>
        /// <returns>Customer Id Message Locator</returns>
        public IWebElement GetCustomerIDMessageLocator()
        {
            return CustomerIDMessage;
        }

        #endregion
    }
}
