using log4net;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.BasePage;
using SeleniumPOM.Utilities;

namespace SeleniumPOM.Pages.Actions
{
    class HomePage : Page, IHomePage
    {
        #region objects

        readonly ILog logger = Log4NetHelper.GetLogger(typeof(HomePage));
        HomePageLocator locator;
        readonly IUtil util = new Utils();

        #endregion

        public HomePage()
        {
            locator = new HomePageLocator();
            PageFactory.InitElements(driver, locator);
        }

        public string GetWelcomeMessage()
        {
            string Text = util.GetElementText(locator.GetWelcomeMessageLocator());
            logger.Info("Welcome message is : " + Text);
            return Text;
        }

        public string GetManagerID()
        {
            string Text = util.GetElementText(locator.GetManagerIDLocator());
            logger.Info("MangerID is : " + Text);
            return Text;
        }

        public NewCustomerPage ClickOnNewCustomerLink()
        {
            util.JSExecutor();
            util.ClickOnElement(locator.GetNewCustomerLinkLocator());
            logger.Info("Clicked on New Customer Page");
            return new NewCustomerPage();
        }

        public EditCustomerPage ClickOnEditCustomerPage()
        {
            util.JSExecutor();
            util.ClickOnElement(locator.GetEditCustomerLinkLocator());
            logger.Info("Clicked On Edit Customer Page");
            return new EditCustomerPage();
        }

        public DeleteCustomerPage ClickOnDeleteCustomerPage()
        {
            util.JSExecutor();
            util.ClickOnElement(locator.GetDeleteCustomerLinkLocator());
            logger.Info("Clicked on Delete Customer Page");
            return new DeleteCustomerPage();
        }

        public NewAccountPage ClickOnNewAccountPage()
        {
            util.JSExecutor();
            util.ClickOnElement(locator.GetNewAccountLinkLocator());
            logger.Info("Clicked on New Account Page");
            return new NewAccountPage();
        }

        public EditAccountPage ClickOnEditAccountPage()
        {
            util.JSExecutor();
            util.ClickOnElement(locator.GetEditAccountLinkLocator());
            logger.Info("Clicked on Edit Customer Page");
            return new EditAccountPage();
        }

        public DeleteAccountPage ClickOnDeleteAccountPage()
        {
            util.JSExecutor();
            util.ClickOnElement(locator.GetDeleteAccountLinkLocator());
            logger.Info("Clicked on Delete Customer Page");
            return new DeleteAccountPage();
        }

        public DepositPage ClickOnDepositPage()
        {
            util.JSExecutorClick(locator.GetDepositLinkLocator());
            logger.Info("Clicked on Deposit Page");
            return new DepositPage();
        }

        public WithdrawalPage ClickOnWithdrawalPage()
        {
            util.JSExecutorClick(locator.GetWithdrawalLinkLocator());
            logger.Info("Clicked on Withdrwal Page");
            return new WithdrawalPage();
        }

        public FundTrasferPage ClickOnFundTransferPage()
        {
            util.JSExecutorClick(locator.GetFundTransferLinkLocator());
            logger.Info("Clicked on Fund Transfer Page");
            return new FundTrasferPage();
        }

        public BalanceEnquiryPage ClickOnBalanceEnquiryPage()
        {
            util.JSExecutorClick(locator.GetBalanceEnquiryLinkLocator());
            logger.Info("Clicked on Balance Enquiry Page");
            return new BalanceEnquiryPage();
        }

        public MiniStatementPage ClickOnMiniSatatementPage()
        {
            util.ClickOnElement(locator.GetMiniStatementLinkLocator());
            logger.Info("Clicked on Ministatement Page");
            return new MiniStatementPage();
        }

        public CustomisedStatementPage ClickOnCustomisedStatementPage()
        {
            util.JSExecutor();
            util.ClickOnElement(locator.GetCustomisedStatementLinkLocator());
            logger.Info("Clicked on Customised Statement Page");
            return new CustomisedStatementPage();
        }

    }
}
