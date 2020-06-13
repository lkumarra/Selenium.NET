using log4net;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.BasePage;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.Utilities;

namespace SeleniumPOM.Pages.Actions
{
    class BalanceEnquiryPage : Page, IBalanceEnquiryPage
    {
        #region Objects

        readonly IUtil util = new Utils();
        BalanceEnquiryLocator locator;
        readonly ILog logger = Log4NetHelper.GetLogger(typeof(BalanceEnquiryPage));

        #endregion

        public BalanceEnquiryPage()
        {
            locator = new BalanceEnquiryLocator();
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
            string Text = GetAccountNumberMessage();
            return Text;
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
    }
}
