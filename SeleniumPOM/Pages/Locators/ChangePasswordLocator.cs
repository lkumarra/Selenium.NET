using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Pages.Locators
{
    class ChangePasswordLocator
    {
        [FindsBy(How = How.Name, Using = "oldpassword")]
        private IWebElement OldPassword { get; set; }

        [FindsBy(How = How.Name, Using = "newpassword")]
        private IWebElement NewPassword { get; set; }

        [FindsBy(How = How.Name, Using = "confirmpassword")]
        private IWebElement ConfirmPassword { get; set; }

        [FindsBy(How = How.Name, Using = "sub")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        /// <summary>
        /// Return the Locator of OldPassword field on ChangePassword Page.
        /// </summary>
        /// <returns>Locator of Change Password field</returns>
        public IWebElement GetOldPasswordLocator()
        {
            return OldPassword;
        }

        /// <summary>
        /// Return the locator of NewPassword field on ChangePassword Page.
        /// </summary>
        /// <returns>Locator of NewPassword Field</returns>
        public IWebElement GetNewPasswordLocator()
        {
            return NewPassword;
        }

        /// <summary>
        /// Return the locator of Confirm Password field on Change Password Page.
        /// </summary>
        /// <returns>Locator of Confirm password field</returns>
        public IWebElement GetConfirmPasswordLocator()
        {
            return ConfirmPassword;
        }

        /// <summary>
        /// Return the Locator of SubmitButton on ChangePassword Page.
        /// </summary>
        /// <returns>Locator of Submit Button</returns>
        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        /// <summary>
        /// Return the locator of Reset Button on ChagePassword Page.
        /// </summary>
        /// <returns>Locator of Reset Button</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }
    }
}
