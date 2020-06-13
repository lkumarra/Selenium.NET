using log4net;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.BasePage;
using SeleniumPOM.Utilities;

namespace SeleniumPOM.Pages.Actions
{
    class NewAccountPage : Page, INewAccountPage
    {
        #region Objects

        readonly ILog logger = Log4NetHelper.GetLogger(typeof(NewAccountPage));
        NewAccountLocator locators;
        readonly IUtil util = new Utils();

        #endregion

        public NewAccountPage()
        {
            locators = new NewAccountLocator();
            PageFactory.InitElements(driver, locators);
        }

        public void SetCustomerID(string CustomerId)
        {
            util.EnterTextIntoElement(locators.GetCustomerIDLocator(), CustomerId);
            logger.Info("CustomerID entered is : " + CustomerId);
        }

        public void SelectAccountType(string AccountType)
        {
            util.SelectByVisibleText(locators.GetAccountTypeLocator(), AccountType);
            logger.Info("Account Type Selected is : " + AccountType);
        }

        public void SetInitialDeposit(string Deposit)
        {
            util.EnterTextIntoElement(locators.GetInitialDepositLocator(), Deposit);
            logger.Info("Initial Deposit entered is : " + Deposit);
        }

        public void ClickOnSubmitButton()
        {
            util.ClickOnElement(locators.GetSubmitButtonLocator());
            logger.Info("Clicked on Submit Button");
        }

        public void ClickOnResetButton()
        {
            util.ClickOnElement(locators.GetResetButtonLocator());
            logger.Info("Clicked on Reset Button");
        }

        public string GetCustomerIDMessage()
        {
            string Text = util.GetElementText(locators.GetCustomerIDMessageLocator());
            logger.Info("CustomerId Message is : " + Text);
            return Text;
        }

        public string EnterInvalidCharacterAndGetCustomerIDMessge(string characters)
        {
            SetCustomerID(characters);
            return GetCustomerIDMessage();
        }

    }
}
