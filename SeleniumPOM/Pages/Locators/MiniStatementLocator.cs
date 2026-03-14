using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class MiniStatementLocator
    {
        #region PageFactory 

        [FindsBy(How = How.Name, Using = "accountno")]
        private IWebElement AccountNo { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.Id, Using = "message2")]
        private IWebElement AccountNumberMessage { get; set; }

        #endregion

        #region GetterMethods

        public IWebElement GetAccountNumberLocator() => AccountNo;
        public IWebElement GetSubmitButtonLocator() => SubmitButton;
        public IWebElement GetResetButtonLocator() => ResetButton;
        public IWebElement GetAccountNumberMessageLocator() => AccountNumberMessage;

        #endregion
    }
}
