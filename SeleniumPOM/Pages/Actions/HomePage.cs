using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.TestBase;
using SeleniumPOM.Utilities;

namespace SeleniumPOM.Pages.Actions
{
    class HomePage : Page, IHomePage
    {

        HomePageLocator locator;
        readonly IUtil util = new Utils();

        public HomePage()
        {
            locator = new HomePageLocator();
            PageFactory.InitElements(driver, locator);
        }

        public string GetWelcomeMessage()
        {
            return util.GetElementText(locator.GetWelcomeMessageLocator());
        }

        public string GetManagerID()
        {
            return util.GetElementText(locator.GetManagerIDLocator());
        }

        public NewCustomerPage ClickOnNewCustomerLink()
        {
            util.ClickOnElement(locator.GetNewCustomerLinkLocator());
            return new NewCustomerPage();
        }

        public EditCustomerPage ClickOnEditCustomerPage()
        {
            util.ClickOnElement(locator.GetEditCustomerLinkLocator());
            return new EditCustomerPage();
        }

        public DeleteCustomerPage ClickOnDeleteCustomerPage()
        {
            util.ClickOnElement(locator.GetDeleteCustomerLinkLocator());
            return new DeleteCustomerPage();
        }

        public NewAccountPage ClickOnNewAccountPage()
        {
            util.ClickOnElement(locator.GetNewAccountLinkLocator());
            return new NewAccountPage();
        }

        public EditAccountPage ClickOnEditAccountPage()
        {
            util.ClickOnElement(locator.GetEditAccountLinkLocator());
            return new EditAccountPage();
        }

        public DeleteAccountPage ClickOnDeleteAccountPage()
        {
            util.ClickOnElement(locator.GetDeleteAccountLinkLocator());
            return new DeleteAccountPage();
        }

        public DepositPage ClickOnDepositPage()
        {
            util.ClickOnElement(locator.GetDepositLinkLocator());
            return new DepositPage();
        }

        public WithdrawalPage ClickOnWithdrawalPage()
        {
            util.ClickOnElement(locator.GetWithdrawalLinkLocator());
            return new WithdrawalPage();
        }

        public FundTrasferPage ClickOnFundTransferPage()
        {
            util.ClickOnElement(locator.GetFundTransferLinkLocator());
            return new FundTrasferPage();
        }

        public ChangePasswordPage ClickOnChangePasswordPage()
        {
            util.ClickOnElement(locator.GetChangePasswordLinkLocator());
            return new ChangePasswordPage();
        }

        public BalanceEnquiryPage ClickOnBalanceEnquiryPage()
        {
            util.ClickOnElement(locator.GetBalanceEnquiryLinkLocator());
            return new BalanceEnquiryPage();
        }

        public MiniStatementPage ClickOnMiniSatatementPage()
        {
            util.ClickOnElement(locator.GetMiniStatementLinkLocator());
            return new MiniStatementPage();
        }

        public CustomisedStatementPage ClickOnCustomisedStatementPage()
        {
            util.ClickOnElement(locator.GetCustomisedStatementLinkLocator());
            return new CustomisedStatementPage();
        }

        public LogoutPage ClickOnLogoutPage()
        {
            util.ClickOnElement(locator.GetLogoutLinkLocator());
            return new LogoutPage();
        }
    }
}
