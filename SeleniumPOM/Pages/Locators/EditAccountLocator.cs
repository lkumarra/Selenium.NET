using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace SeleniumPOM.Pages.Locators
{
    class EditAccountLocator
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
        /// Return the locator of ResetButton on Edit Account  Page.
        /// </summary>
        /// <returns>Locator of Reset Button</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }

        /// <summary>
        /// Return the locator of Account Number Message on Edit Account Page.
        /// </summary>
        /// <returns>Locator of Account Number Message</returns>
        public IWebElement GetAccountNumberMessageLocator()
        {
            return AccountNumberMessage;
        }

        #endregion
    }
}
