using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Pages.Locators
{
    class EditAccountLocator
    {
        [FindsBy(How = How.Name, Using = "accountno")]
        private IWebElement AccountNo { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        /// <summary>
        /// Return the locator of Account Number field on Edit Account Page.
        /// </summary>
        /// <returns>Locator of Account Number field</returns>
        public IWebElement GetAccountNumberLocator()
        {
            return AccountNo;
        }

        /// <summary>
        /// Return the locator of Submit Button on Edit Account Page.
        /// </summary>
        /// <returns>Loactor of Submit Button</returns>
        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        /// <summary>
        /// Return the locator of ResetButton on New Customer Page.
        /// </summary>
        /// <returns>Locator of Reset Button</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }
    }
}
