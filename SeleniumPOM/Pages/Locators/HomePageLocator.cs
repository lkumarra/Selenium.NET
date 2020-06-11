using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace SeleniumPOM.Pages.Locators
{
    class HomePageLocator
    {
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

        /// <summary>
        /// Return the locator of welcome message.
        /// </summary>
        /// <returns>Welcome Message Locator</returns>
        public IWebElement GetWelcomeMessageLocator()
        {
            return WelcomeMessage;
        }

        /// <summary>
        /// Return the Locator of Manager ID.
        /// </summary>
        /// <returns>Manager ID Locator</returns>
        public IWebElement GetManagerIDLocator()
        {
            return ManagerID;
        }

        /// <summary>
        /// Return the Locator of EditCustomer Link.
        /// </summary>
        /// <returns>New Customer Link Locator</returns>
        public IWebElement GetNewCustomerLinkLocator()
        {
            return NewCustomerLink;
        }

        /// <summary>
        /// Return the locator of NewCustomer Link.
        /// </summary>
        /// <returns>Edit Customer Link Locator</returns>
        public IWebElement GetEditCustomerLinkLocator()
        {
            return EditCustomer;
        }

        /// <summary>
        /// Return the locator of DeleteCustomer Link.
        /// </summary>
        /// <returns>DeleteCustomer link locator</returns>
        public IWebElement GetDeleteCustomerLinkLocator()
        {
            return DeleteCustomer;
        }

        /// <summary>
        /// Return the Locator of NewAccount Link.
        /// </summary>
        /// <returns>NewAccount Link Locator</returns>
        public IWebElement GetNewAccountLinkLocator()
        {
            return NewAccount;
        }

        /// <summary>
        /// Return the locator of EditAccount Link.
        /// </summary>
        /// <returns>EditAccount Link Locator</returns>
        public IWebElement GetEditAccountLinkLocator()
        {
            return EditAccount;
        }

        /// <summary>
        /// Return the locator of DeleteAccount Link.
        /// </summary>
        /// <returns></returns>
        public IWebElement GetDeleteAccountLinkLocator()
        {
            return DeleteAccount;
        }

        /// <summary>
        /// Return the locator of Deposit Link.
        /// </summary>
        /// <returns>Deposit Link Locator</returns>
        public IWebElement GetDepositLinkLocator()
        {
            return Deposit;
        }

        /// <summary>
        /// Return the locator of withdrawal Link
        /// </summary>
        /// <returns>Withdrawal link locator</returns>
        public IWebElement GetWithdrawalLinkLocator()
        {
            return Withdrawl;
        }

        /// <summary>
        /// Return the locator of fundtransfer link.
        /// </summary>
        /// <returns>FundTransfer Link Locator</returns>
        public IWebElement GetFundTransferLinkLocator()
        {
            return FundTrasfer;
        }

        /// <summary>
        /// Return the locator of ChangePassword Link.
        /// </summary>
        /// <returns>ChangePassword Link Locator</returns>
        public IWebElement GetChangePasswordLinkLocator()
        {
            return ChangePassword;
        }

        /// <summary>
        /// Return the locator of BalaceEnquiry Link.
        /// </summary>
        /// <returns>Balance Enquiry Link Locator.</returns>
        public IWebElement GetBalanceEnquiryLinkLocator()
        {
            return BalanceEnquiry;
        }

        /// <summary>
        /// Return the locator of Ministatement link.
        /// </summary>
        /// <returns>MiniStatement Link Locator</returns>
        public IWebElement GetMiniStatementLinkLocator()
        {
            return MiniStatement;
        }

        /// <summary>
        /// Return the locator of Customised link.
        /// </summary>
        /// <returns>Customised Link Locator</returns>
        public IWebElement GetCustomisedStatementLinkLocator()
        {
            return CustomisedStatement;
        }

        /// <summary>
        /// Return the locator of logour link.
        /// </summary>
        /// <returns>Logout Link Locator</returns>
        public IWebElement GetLogoutLinkLocator()
        {
            return Logout;
        }
    }
}
