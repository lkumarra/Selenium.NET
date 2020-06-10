using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Pages.Locators
{
    class EditCostumerLocator
    {
        [FindsBy(How = How.Name, Using = "cusid")]
        private IWebElement CosutumerId { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.Id, Using = "message14")]
        private IWebElement CustomerIDMessage { get; set; }

        /// <summary>
        /// Return the locator of Customer Id field.
        /// </summary>
        /// <returns>Customer Id field locator</returns>
        public IWebElement GetCostumerIDLocator()
        {
            return CosutumerId;
        }

        /// <summary>
        /// Return the locator of Submit Button.
        /// </summary>
        /// <returns>Submit Button Locator</returns>
        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        /// <summary>
        /// Return the locator of Reset Button.
        /// </summary>
        /// <returns>Reset Button Locator</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }

        /// <summary>
        /// Return the locator of customer id message.
        /// </summary>
        /// <returns>Customer Id Message Locator</returns>
        public IWebElement GetCustomerIDMessageLocator()
        {
            return CustomerIDMessage;
        }


    }
}
