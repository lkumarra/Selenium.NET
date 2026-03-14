using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumPOM.Pages.Locators
{
    class NewCustomerLocators
    {
        #region PageFactory 

        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement CustomerName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value = 'm']")]
        private IWebElement MaleRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value = 'f']")]
        private IWebElement FemaleRadioButton { get; set; }

        [FindsBy(How = How.Name, Using = "dob")]
        private IWebElement DOB { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@name = 'addr']")]
        private IWebElement Address { get; set; }

        [FindsBy(How = How.Name, Using = "city")]
        private IWebElement City { get; set; }

        [FindsBy(How = How.Name, Using = "state")]
        private IWebElement State { get; set; }

        [FindsBy(How = How.Name, Using = "pinno")]
        private IWebElement PIN { get; set; }

        [FindsBy(How = How.Name, Using = "telephoneno")]
        private IWebElement Mobile { get; set; }

        [FindsBy(How = How.Name, Using = "emailid")]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value  = 'Submit']")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value  = 'Reset']")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label#message")]
        private IWebElement CustomerNameMessage { get; set; }

        #endregion

        #region GetterMethods

        public IWebElement GetCustomerNameLocator() => CustomerName;
        public IWebElement GetMaleRadioButtonLocator() => MaleRadioButton;
        public IWebElement GetFemaleRadioButtonLocator() => FemaleRadioButton;
        public IWebElement GetDOBLocator() => DOB;
        public IWebElement GetAddressLocator() => Address;
        public IWebElement GetCityLocator() => City;
        public IWebElement GetStateLocator() => State;
        public IWebElement GetPINLocator() => PIN;
        public IWebElement GetMobileLocator() => Mobile;
        public IWebElement GetEmailLocator() => Email;
        public IWebElement GetPasswordLocator() => Password;
        public IWebElement GetSubmitButtonLocator() => SubmitButton;
        public IWebElement GetResetButtonLocator() => ResetButton;
        public IWebElement GetCustomerNameMessageLocator() => CustomerNameMessage;

        #endregion
    }
}
