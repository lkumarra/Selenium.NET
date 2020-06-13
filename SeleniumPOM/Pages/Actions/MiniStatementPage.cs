using log4net;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.BasePage;
using SeleniumPOM.Utilities;

namespace SeleniumPOM.Pages.Actions
{
    class MiniStatementPage : Page, IMiniStatementPage
    {
        #region Objects

        readonly ILog logger = Log4NetHelper.GetLogger(typeof(MiniStatementPage));
        readonly IUtil util = new Utils();
        MiniStatementLocator locator;

        #endregion

        public MiniStatementPage()
        {
            locator = new MiniStatementLocator();
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
            logger.Info("Account Number entered is : " + AccountNo);
        }
    }
}
