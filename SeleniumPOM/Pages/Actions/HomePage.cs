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
        readonly Utils util = new Utils();

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


    }
}
