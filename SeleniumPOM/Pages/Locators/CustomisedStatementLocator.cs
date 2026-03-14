using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class CustomisedStatementLocator
    {
        #region PageFactory

        [FindsBy(How = How.Name, Using = "accountno")]
        private IWebElement AccountNo { get; set; }

        [FindsBy(How = How.Name, Using = "fdate")]
        private IWebElement FromDate { get; set; }

        [FindsBy(How = How.Name, Using = "tdate")]
        private IWebElement ToDate { get; set; }

        [FindsBy(How = How.Name, Using = "amountlowerlimit")]
        private IWebElement MinimumTransactionValue { get; set; }

        [FindsBy(How = How.Name, Using = "numtransaction")]
        private IWebElement NumberOfTransaction { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='accountno']/following-sibling::label")]
        private IWebElement AccountNumberMessage { get; set; }

        #endregion

        #region GetterMethods

        public IWebElement GetAccountNumberLocator() => AccountNo;
        public IWebElement GetFromDateLocator() => FromDate;
        public IWebElement GetToDateLocator() => ToDate;
        public IWebElement GetMinimumTransactionValueLocator() => MinimumTransactionValue;
        public IWebElement GetNumberOfTransactionLocator() => NumberOfTransaction;
        public IWebElement GetSubmitButtonLocator() => SubmitButton;
        public IWebElement GetResetButtonLocator() => ResetButton;
        public IWebElement GetAccountNumberMessageLocator() => AccountNumberMessage;

        #endregion
    }
}
