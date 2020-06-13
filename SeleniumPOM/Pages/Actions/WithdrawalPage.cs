using log4net;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.BasePage;
using SeleniumPOM.Utilities;

namespace SeleniumPOM.Pages.Actions
{
    class WithdrawalPage : Page, IWithdrawalPage
    {
        #region Objects

        readonly ILog logger = Log4NetHelper.GetLogger(typeof(WithdrawalPage));
        readonly IUtil util = new Utils();
        WithdrawalLocator locator;

        #endregion

        public WithdrawalPage()
        {
            locator = new WithdrawalLocator();
            PageFactory.InitElements(driver, locator);
        }

        public void SetAccountNumber(string AccountNo)
        {
            util.EnterTextIntoElement(locator.GetAccountNumberLocator(), AccountNo);
            logger.Info("Account Number entered is : " + AccountNo);
        }

        public void SetAmount(string Amount)
        {
            util.EnterTextIntoElement(locator.GetAmountLocator(), Amount);
            logger.Info("Amount enterd is : " + Amount);
        }

        public void SetDescription(string Description)
        {
            util.EnterTextIntoElement(locator.GetDescriptionLocator(), Description);
            logger.Info("Descriptio entered is : " + Description);
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

        public string GetAccountNumberMessage()
        {
            string Text = util.GetElementText(locator.GetAccountNumberMessage());
            logger.Info("Account Number Message is : " + Text);
            return Text;
        }

        public string EnterInvalidCharactersAndGetAccountNumberMessage(string Characters)
        {
            SetAccountNumber(Characters);
            return GetAccountNumberMessage();
        }
    }
}
