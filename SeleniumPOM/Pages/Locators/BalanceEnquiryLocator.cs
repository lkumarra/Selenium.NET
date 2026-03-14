using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

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

        public IWebElement GetAccountNumberLocator()
        {
            return AccountNo;
        }

        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }

        public IWebElement GetAccountNumberMessageLocator()
        {
            return AccountNumberMessage;
        }

        #endregion
    }
}
