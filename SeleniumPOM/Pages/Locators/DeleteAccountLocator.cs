using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class DeleteAccountLocator
    {
        #region PageFactory

        [FindsBy(How = How.Name, Using = "accountno")]
        private IWebElement AccounNo { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@id,'message')]")]
        private IWebElement AccountNoMessage { get; set; }

        #endregion

        #region GetterMethods

        public IWebElement GetAccountNumberLocator() => AccounNo;
        public IWebElement GetSubmitButtonLocator() => SubmitButton;
        public IWebElement GetResetButtonLocator() => ResetButton;
        public IWebElement GetAccountNumberMessageLocator() => AccountNoMessage;

        #endregion
    }
}
