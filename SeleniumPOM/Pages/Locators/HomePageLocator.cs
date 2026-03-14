using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class HomePageLocator
    {
        #region PageFactory 

        [FindsBy(How = How.XPath, Using = "//marquee[@class = 'heading3']")]
        private IWebElement WelcomeMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "tr.heading3>td:first-child")]
        private IWebElement ManagerID { get; set; }

        [FindsBy(How = How.LinkText, Using = "New Customer")]
        private IWebElement NewCustomerLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Edit Customer")]
        private IWebElement EditCustomer { get; set; }

        [FindsBy(How = How.LinkText, Using = "Delete Customer")]
        private IWebElement DeleteCustomer { get; set; }

        [FindsBy(How = How.LinkText, Using = "New Account")]
        private IWebElement NewAccount { get; set; }

        [FindsBy(How = How.LinkText, Using = "Edit Account")]
        private IWebElement EditAccount { get; set; }

        [FindsBy(How = How.LinkText, Using = "Delete Account")]
        private IWebElement DeleteAccount { get; set; }

        [FindsBy(How = How.LinkText, Using = "Deposit")]
        private IWebElement Deposit { get; set; }

        [FindsBy(How = How.LinkText, Using = "Withdrawal")]
        private IWebElement Withdrawl { get; set; }

        [FindsBy(How = How.LinkText, Using = "Fund Transfer")]
        private IWebElement FundTrasfer { get; set; }

        [FindsBy(How = How.LinkText, Using = "Change Password")]
        private IWebElement ChangePassword { get; set; }

        [FindsBy(How = How.LinkText, Using = "Balance Enquiry")]
        private IWebElement BalanceEnquiry { get; set; }

        [FindsBy(How = How.LinkText, Using = "Mini Statement")]
        private IWebElement MiniStatement { get; set; }

        [FindsBy(How = How.LinkText, Using = "Customised Statement")]
        private IWebElement CustomisedStatement { get; set; }

        [FindsBy(How = How.LinkText, Using = "Log out")]
        private IWebElement Logout { get; set; }

        #endregion

        #region GetterMethods

        public IWebElement GetWelcomeMessageLocator()
        {
            return WelcomeMessage;
        }

        public IWebElement GetManagerIDLocator()
        {
            return ManagerID;
        }

        public IWebElement GetNewCustomerLinkLocator()
        {
            return NewCustomerLink;
        }

        public IWebElement GetEditCustomerLinkLocator()
        {
            return EditCustomer;
        }

        public IWebElement GetDeleteCustomerLinkLocator()
        {
            return DeleteCustomer;
        }

        public IWebElement GetNewAccountLinkLocator()
        {
            return NewAccount;
        }

        public IWebElement GetEditAccountLinkLocator()
        {
            return EditAccount;
        }

        public IWebElement GetDeleteAccountLinkLocator()
        {
            return DeleteAccount;
        }

        public IWebElement GetDepositLinkLocator()
        {
            return Deposit;
        }

        public IWebElement GetWithdrawalLinkLocator()
        {
            return Withdrawl;
        }

        public IWebElement GetFundTransferLinkLocator()
        {
            return FundTrasfer;
        }

        public IWebElement GetChangePasswordLinkLocator()
        {
            return ChangePassword;
        }

        public IWebElement GetBalanceEnquiryLinkLocator()
        {
            return BalanceEnquiry;
        }

        public IWebElement GetMiniStatementLinkLocator()
        {
            return MiniStatement;
        }

        public IWebElement GetCustomisedStatementLinkLocator()
        {
            return CustomisedStatement;
        }

        public IWebElement GetLogoutLinkLocator()
        {
            return Logout;
        }

        #endregion
    }
}
