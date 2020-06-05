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

        public IWebElement GetWelcomeMessageLocator()
        {
            return this.WelcomeMessage;
        }

        public IWebElement GetManagerIDLocator()
        {
            return this.ManagerID;
        }

        public IWebElement GetNewCustomerLinkLocator()
        {
            return this.NewCustomerLink;
        }

        public IWebElement GetEditCustomerLinkLocator()
        {
            return this.EditCustomer;
        }

    }
}
