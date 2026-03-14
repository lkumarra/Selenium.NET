using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class NewAccountLocator
    {
        #region PageFactory

        [FindsBy(How = How.Name, Using = "cusid")]
        private IWebElement CustomerID { get; set; }

        [FindsBy(How = How.Name, Using = "selaccount")]
        private IWebElement AccountType { get; set; }

        [FindsBy(How = How.Name, Using = "inideposit")]
        private IWebElement InitialDeposit { get; set; }

        [FindsBy(How = How.Name, Using = "button2")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "reset")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='cusid']/following-sibling::label")]
        private IWebElement CustomerIdMessage { get; set; }

        #endregion

        #region GetterMethods

        public IWebElement GetCustomerIDLocator() => CustomerID;
        public IWebElement GetAccountTypeLocator() => AccountType;
        public IWebElement GetInitialDepositLocator() => InitialDeposit;
        public IWebElement GetSubmitButtonLocator() => SubmitButton;
        public IWebElement GetResetButtonLocator() => ResetButton;
        public IWebElement GetCustomerIDMessageLocator() => CustomerIdMessage;

        #endregion
    }
}
