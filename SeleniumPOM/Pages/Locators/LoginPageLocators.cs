using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class LoginPageLocators
    {
        #region PageFactory 

        [FindsBy(How = How.Name, Using = "uid")]
        private IWebElement UserID { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "btnLogin")]
        private IWebElement LoginButton { get; set; }

        [FindsBy(How = How.Name, Using = "btnReset")]
        private IWebElement ResetButton { get; set; }

        #endregion

        #region GetterMethods

        /// <summary>
        /// Return the locator of UserID Field.
        /// </summary>
        /// <returns>UserID Field Locator</returns>
        public IWebElement GetUserIDLocator()
        {
            return UserID;
        }

        /// <summary>
        /// Return the locator of Password Field.
        /// </summary>
        /// <returns>Password field locator</returns>
        public IWebElement GetPasswordLocator()
        {
            return Password;
        }

        /// <summary>
        /// Return the locator of login button.
        /// </summary>
        /// <returns>Login Button Locator</returns>
        public IWebElement GetLoginButtonLocator()
        {
            return LoginButton;
        }

        /// <summary>
        /// Return the locator of reset button.
        /// </summary>
        /// <returns>Reset Button Locator</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }

        #endregion
    }
}
