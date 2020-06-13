using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

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

        /// <summary>
        /// Return the Locator of CustomerNameField on NewCustomer Page.
        /// </summary>
        /// <returns> Customer Name Locator </returns>
        public IWebElement GetCustomerNameLocator()
        {
            return CustomerName;
        }

        /// <summary>
        /// Return the Locator of Male Radio Button on NewCustomer Page.
        /// </summary>
        /// <returns>Locator of Male Radio Button</returns>
        public IWebElement GetMaleRadioButtonLocator()
        {
            return MaleRadioButton;
        }

        /// <summary>
        /// Return the Locator of Female Radio Button on NewCustomer Page.
        /// </summary>
        /// <returns>Locator of Female Radio Button</returns>
        public IWebElement GetFemaleRadioButtonLocator()
        {
            return FemaleRadioButton;
        }

        /// <summary>
        /// Return the Locator of DOB field on NewCustomer Page.
        /// </summary>
        /// <returns>Locator of DOB field</returns>
        public IWebElement GetDOBLocator()
        {
            return DOB;
        }

        /// <summary>
        /// Return the locator of address field on NewCustomer Page.
        /// </summary>
        /// <returns>Locator of Address field</returns>
        public IWebElement GetAddressLocator()
        {
            return Address;
        }

        /// <summary>
        /// Return the locator of city field on NewCustomer Page.
        /// </summary>
        /// <returns>Locator of City field</returns>
        public IWebElement GetCityLocator()
        {
            return City;
        }

        /// <summary>
        /// Return the locator of state filed on NewCustomer Page.
        /// </summary>
        /// <returns>Locator of State field</returns>
        public IWebElement GetStateLocator()
        {
            return State;
        }

        /// <summary>
        /// Return the locator of PIN field on NewCustomer Page.
        /// </summary>
        /// <returns>Locator of PIN Field</returns>
        public IWebElement GetPINLocator()
        {
            return PIN;
        }

        /// <summary>
        /// Return the locator of Mobile field on NewCustomer Page.
        /// </summary>
        /// <returns>Locator of Mobile field</returns>
        public IWebElement GetMobileLocator()
        {
            return Mobile;
        }

        /// <summary>
        /// Return the locator of Email field on NewCustomer Page.
        /// </summary>
        /// <returns>Locator of Email field</returns>
        public IWebElement GetEmailLocator()
        {
            return Email;
        }

        /// <summary>
        /// Return the locator of Password field on NewCustomer Page.
        /// </summary>
        /// <returns>Locator of Password field</returns>
        public IWebElement GetPasswordLocator()
        {
            return Password;
        }

        /// <summary>
        /// Return the locator of SubmitButton of NewCustomer Page.
        /// </summary>
        /// <returns>Locator of Submit Button</returns>
        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        /// <summary>
        /// Return the locator of Reset Button on NewCustomer Page.
        /// </summary>
        /// <returns>Locator of Reset Button</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }

        /// <summary>
        /// Return the locator of Customer Name Message on NewCustomer Page.
        /// </summary>
        /// <returns>Locator f Customer Name Message</returns>
        public IWebElement GetCustomerNameMessageLocator()
        {
            return CustomerNameMessage;
        }

        #endregion
    }
}
