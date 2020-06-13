using log4net;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.BasePage;
using SeleniumPOM.Utilities;


namespace SeleniumPOM.Pages.Actions
{
    class DeleteCustomerPage : Page, IDeleteCustomerPage
    {
        #region Objects 

        DeleteCustomerLocator locator;
        readonly IUtil util = new Utils();
        readonly ILog logger = Log4NetHelper.GetLogger(typeof(DeleteCustomerPage));

        #endregion

        public DeleteCustomerPage()
        {
            locator = new DeleteCustomerLocator();
            PageFactory.InitElements(driver, locator);
        }

        public void SetCustomerID(string CustomerID)
        {
            util.EnterTextIntoElement(locator.GetCustomerIDLocator(), CustomerID);
            logger.Info("Customer ID entered is : " + CustomerID);
        }

        public void ClickOnSubmitButton()
        {
            util.ClickOnElement(locator.GetSubmitButtonLocator());
            logger.Info("Clicked on Submit Button");
        }

        public void ClickOnResetButton()
        {
            util.ClickOnElement(locator.GetResetButtonLocator());
            logger.Info("Clicked on Reset Button");
        }

        public string GetCustomerIDMessage()
        {
            string Text = util.GetElementText(locator.GetCustomerIDMessageLocator());
            logger.Info("CustomerID Message is : " + Text);
            return Text;
        }

        public string EnterInvalidCharacterAndGetMessage(string characters)
        {
            SetCustomerID(characters);
            return GetCustomerIDMessage();
        }
    }
}
