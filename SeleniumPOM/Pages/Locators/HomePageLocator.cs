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

    }
}
