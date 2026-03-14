using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class EditCostumerLocator
    {
        #region PageFactory

        [FindsBy(How = How.Name, Using = "cusid")]
        private IWebElement CosutumerId { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.Id, Using = "message14")]
        private IWebElement CustomerIDMessage { get; set; }

        #endregion

        #region GetterMethods

        public IWebElement GetCostumerIDLocator() => CosutumerId;
        public IWebElement GetSubmitButtonLocator() => SubmitButton;
        public IWebElement GetResetButtonLocator() => ResetButton;
        public IWebElement GetCustomerIDMessageLocator() => CustomerIDMessage;

        #endregion
    }
}
