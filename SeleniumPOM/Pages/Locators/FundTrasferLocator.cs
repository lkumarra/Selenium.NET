using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class FundTrasferLocator
    {
        #region PageFactory 

        [FindsBy(How = How.Name, Using = "payersaccount")]
        private IWebElement PayersAccNo { get; set; }

        [FindsBy(How = How.Name, Using = "payeeaccount")]
        private IWebElement PayeesAccNo { get; set; }

        [FindsBy(How = How.Name, Using = "ammount")]
        private IWebElement Amount { get; set; }

        [FindsBy(How = How.Name, Using = "desc")]
        private IWebElement Description { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='payersaccount']/following-sibling::label")]
        private IWebElement PayersAccountMessage { get; set; }

        #endregion

        #region GetterMethods

        public IWebElement GetPayersAccNoLocator() => PayersAccNo;
        public IWebElement GetPayessAccNoLocator() => PayeesAccNo;
        public IWebElement GetAmountLocator() => Amount;
        public IWebElement GetDescriptionLocator() => Description;
        public IWebElement GetSubmitButtonLocator() => SubmitButton;
        public IWebElement GetResetButtonLocator() => ResetButton;
        public IWebElement GetPayersAccountMessageLocator() => PayersAccountMessage;

        #endregion
    }
}
