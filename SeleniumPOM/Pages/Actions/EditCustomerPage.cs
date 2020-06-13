using log4net;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.BasePage;
using SeleniumPOM.Utilities;


namespace SeleniumPOM.Pages.Actions
{
    class EditCustomerPage : Page, IEditCostumerPage
    {
        #region Objects 

        readonly Utils util = new Utils();
        EditCostumerLocator locator;
        readonly ILog logger = Log4NetHelper.GetLogger(typeof(EditCustomerPage));

        #endregion

        public EditCustomerPage()
        {
            locator = new EditCostumerLocator();
            PageFactory.InitElements(driver, locator);

        }

        public void SetCostumerID(string CostumerID)
        {
            util.EnterTextIntoElement(locator.GetCostumerIDLocator(), CostumerID);
            logger.Info("CustomerID message is : " + CostumerID);
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

        public string GetCostumerIDMessage()
        {
            string Text = util.GetElementText(locator.GetCustomerIDMessageLocator());
            logger.Info("CustomerID Message is : " + Text);
            return Text;
        }

        public string CustomerIDInvaildCharactersAndMessageText(string Characters)
        {
            SetCostumerID(Characters);
            return GetCostumerIDMessage();
        }

        public string GetCostumerIDAlertMessage()
        {
            string AlertText = util.GetAlertTextAndAccept();
            logger.Info("Alert Text is : " + AlertText);
            return AlertText;
        }

    }
}
