using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Pages.Locators
{
    class BalanceEnquiryLocator
    {

        [FindsBy(How = How.Name, Using = "accountno")]
        private IWebElement AccountNo { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        /// <summary>
        /// Return the locator of account number field on Balance Enquiry Page.
        /// </summary>
        /// <returns>Locator of Account numer field</returns>
        public IWebElement GetAccountNumberLocator()
        {
            return AccountNo;
        }

        /// <summary>
        /// Return the locator of Submit Button on Balance Enquiry Page.
        /// </summary>
        /// <returns>Locator of Submit Button</returns>
        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        /// <summary>
        /// Return the locator of Reset Button on Balance Enquiry Page.
        /// </summary>
        /// <returns>Locator of Reset Button</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }
    }
}
