using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class WithdrawalLocator
    {
        #region PageFactory 

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

        #endregion

        #region GetterMethods

        public IWebElement GetAccountNumberLocator() => AccountNo;
        public IWebElement GetAmountLocator() => Amount;
        public IWebElement GetDescriptionLocator() => Description;
        public IWebElement GetSubmitButtonLocator() => SubmitButton;
        public IWebElement GetResetButtonLocator() => ResetButton;
        public IWebElement GetAccountNumberMessage() => AccountNumberMessage;

        #endregion
    }
}
