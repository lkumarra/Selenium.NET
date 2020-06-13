using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class BalanceEnquiryLocator
    {

        #region PageFactory

        [FindsBy(How = How.Name, Using = "accountno")]
        private IWebElement AccountNo { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='accountno']/following-sibling::label")]
        private IWebElement AccountNumberMessage { get; set; }

        #endregion

        #region GetterMethods
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

        /// <summary>
        /// Return the locator of Account Number Message.
        /// </summary>
        /// <returns>Locator of account number message</returns>
        public IWebElement GetAccountNumberMessageLocator()
        {
            return AccountNumberMessage;
        }

        #endregion
    }
}
