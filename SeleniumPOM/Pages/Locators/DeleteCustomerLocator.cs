using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class DeleteCustomerLocator
    {
        #region PageFactory 

        [FindsBy(How = How.Name, Using = "cusid")]
        private IWebElement CustomerID { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@id, 'message')]")]
        private IWebElement CustomerIDMessage { get; set; }

        #endregion

        #region GetterMethods

        public IWebElement GetCustomerIDLocator() => CustomerID;
        public IWebElement GetSubmitButtonLocator() => SubmitButton;
        public IWebElement GetResetButtonLocator() => ResetButton;
        public IWebElement GetCustomerIDMessageLocator() => CustomerIDMessage;

        #endregion
    }
}
