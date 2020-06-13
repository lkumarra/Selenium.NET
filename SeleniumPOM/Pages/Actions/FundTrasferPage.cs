using log4net;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.BasePage;
using SeleniumPOM.Utilities;

namespace SeleniumPOM.Pages.Actions
{
    class FundTrasferPage : Page, IFundTransferPage
    {
        #region Objects 

        readonly IUtil util = new Utils();
        FundTrasferLocator locator;
        readonly ILog logger = Log4NetHelper.GetLogger(typeof(FundTrasferPage));

        #endregion

        public FundTrasferPage()
        {
            locator = new FundTrasferLocator();
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

        public string EnterInvalidCharactersAndGetPayersAccountMessage(string Characters)
        {
            SetPayersAccountNumber(Characters);
            return GetPayersAccountNumberMessage();
        }

        public string GetPayersAccountNumberMessage()
        {
            string Text = util.GetElementText(locator.GetPayersAccountMessageLocator());
            logger.Info("Payers Account Number Message is : " + Text);
            return Text;
        }

        public void SetAmount(string Amount)
        {
            util.EnterTextIntoElement(locator.GetAmountLocator(), Amount);
            logger.Info("Amount entered is : " + Amount);
        }

        public void SetDescription(string Description)
        {
            util.EnterTextIntoElement(locator.GetDescriptionLocator(), Description);
            logger.Info("Description entered is : " + Description);
        }

        public void SetPayeesAccountNumber(string AccountNo)
        {
            util.EnterTextIntoElement(locator.GetPayessAccNoLocator(), AccountNo);
            logger.Info("Payees Account Number entered is : " + AccountNo);
        }

        public void SetPayersAccountNumber(string AccountNo)
        {
            util.EnterTextIntoElement(locator.GetPayersAccNoLocator(), AccountNo);
            logger.Info("Payers Account Number entered is : " + AccountNo);
        }
    }
}
