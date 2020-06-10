using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.TestBase;
using SeleniumPOM.Utilities;

namespace SeleniumPOM.Pages.Actions
{
    class LoginPage : Page, ILoginPage
    {
        LoginPageLocators locators;
        readonly IUtil utils = new Utils();

        public LoginPage()
        {
            locators = new LoginPageLocators();
            PageFactory.InitElements(driver, locators);
        }
        
        public void SetUserName(string UserName)
        {
            utils.EnterTextIntoElement(locators.GetUserIDLocator(), UserName);
        }

        public void SetPassword(string Password)
        {
            utils.EnterTextIntoElement(locators.GetPasswordLocator(), Password);
        }

        public void ClickOnLogin()
        {
            utils.ClickOnElement(locators.GetLoginButtonLocator());
        }

        public void ClickOnReset()
        {
            utils.ClickOnElement(locators.GetPasswordLocator());
        }

        public HomePage Login(string UserName, string Passeword)
        {
            this.SetUserName(UserName);
            this.SetPassword(Passeword);
            this.ClickOnLogin();
            return new HomePage();
        }
    }
}
