using log4net;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.BasePage;
using SeleniumPOM.Utilities;

namespace SeleniumPOM.Pages.Actions
{
    class CustomisedStatementPage : Page, ICustomisedStatementPage
    {
        #region Objects

        readonly IUtil util = new Utils();
        CustomisedStatementLocator locator;
        readonly ILog logger = Log4NetHelper.GetLogger(typeof(CustomisedStatementPage));

        #endregion

        public CustomisedStatementPage()
        {
            locator = new CustomisedStatementLocator();
            PageFactory.InitElements(driver, locator);
        }

        public void ClickOnResetButton()
        {
            util.ClickOnElement(locator.GetResetButtonLocator());
            logger.Info("Clicked on Reset Button");
        }

        public void ClickOnSubmitButton()
        {
            util.ClickOnElement(locator.GetSubmitButtonLocator());
            logger.Info("Clicked on Submit Button");
        }

        public string EnterInvalidCharactersAndGetMessage(string Characters)
        {
            SetAccountNumber(Characters);
            return GetAccountNumberMessage();
        }

        public string GetAccountNumberMessage()
        {
            string Text = util.GetElementText(locator.GetAccountNumberMessageLocator());
            logger.Info("Account Number Message is : " + Text);
            return Text;
        }

        public void SetAccountNumber(string AccountNo)
        {
            util.EnterTextIntoElement(locator.GetAccountNumberLocator(), AccountNo);
            logger.Info("Account Number Entered is : " + AccountNo);
        }

        public void SetFromDate(string Date)
        {
            util.EnterTextIntoElement(locator.GetFromDateLocator(), Date);
            logger.Info("From Date Selected is : " + Date);
        }

        public void SetMinimunTransactionValue(string Value)
        {
            util.EnterTextIntoElement(locator.GetMinimumTransactionValueLocator(), Value);
            logger.Info("Minimum Transaction value entered is :" + Value);
        }

        public void SetNumberOfTransaction(string Number)
        {
            util.EnterTextIntoElement(locator.GetNumberOfTransactionLocator(), Number);
            logger.Info("Number of Transaction entered are : " + Number);
        }

        public void SetToDate(string Date)
        {
            util.EnterTextIntoElement(locator.GetToDateLocator(), Date);
            logger.Info("To Date Selected is : " + Date);
        }
    }
}
