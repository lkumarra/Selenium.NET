using log4net;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.BasePage;
using SeleniumPOM.Utilities;

namespace SeleniumPOM.Pages.Actions
{
    class LoginPage : Page, ILoginPage
    {
        #region objects

        readonly ILog logger = Log4NetHelper.GetLogger(typeof(LoginPage));
        LoginPageLocators locators;
        readonly IUtil utils = new Utils();

        #endregion

        public LoginPage()
        {
            locators = new LoginPageLocators();
            PageFactory.InitElements(driver, locators);
        }

        public void SetUserName(string UserName)
        {
            utils.EnterTextIntoElement(locators.GetUserIDLocator(), UserName);
            logger.Info("UserName entered is : " + UserName);
        }

        public void SetPassword(string Password)
        {
            utils.EnterTextIntoElement(locators.GetPasswordLocator(), Password);
            logger.Info("Password entered is : " + Password);
        }

        public void ClickOnLogin()
        {
            utils.ClickOnElement(locators.GetLoginButtonLocator());
            logger.Info("Clicked on Login Button");
        }

        public void ClickOnReset()
        {
            utils.ClickOnElement(locators.GetPasswordLocator());
            logger.Info("Clicked on Reset Button");
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
