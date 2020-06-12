using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.TestBase;
using SeleniumPOM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Pages.Actions
{
    class EditAccountPage : Page, IEditAccountPage
    {
        readonly IUtil util = new Utils();
        EditAccountLocator locator;

        public EditAccountPage()
        {
            locator = new EditAccountLocator();
            PageFactory.InitElements(driver, locator);
        }

        public void SetAccountNumber(string AccountNo)
        {
            util.EnterTextIntoElement(locator.GetAccountNumberLocator(), AccountNo);
        }

        public void ClickOnResetButton()
        {
            util.ClickOnElement(locator.GetResetButtonLocator());
        }

        public void ClickOnSubmitButton()
        {
            util.ClickOnElement(locator.GetSubmitButtonLocator());
        }

        public string GetAccountNumberMessage()
        {
            return util.GetElementText(locator.GetAccountNumberMessageLocator());
        }

        public string EnterInvalidCharactersAndGetMessage(string Characters)
        {
            SetAccountNumber(Characters);
            return GetAccountNumberMessage();
        }

    }
}
