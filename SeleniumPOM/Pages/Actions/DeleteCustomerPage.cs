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
    class DeleteCustomerPage : Page, IDeleteCustomerPage
    {
        DeleteCustomerLocator locator;
        readonly IUtil util = new Utils();

        public DeleteCustomerPage()
        {
            locator = new DeleteCustomerLocator();
            PageFactory.InitElements(driver, locator);
        }

        public void SetCustomerID(string CustomerID)
        {
            util.EnterTextIntoElement(locator.GetCustomerIDLocator(), CustomerID);
        }

        public void ClickOnSubmitButton()
        {
            util.ClickOnElement(locator.GetSubmitButtonLocator());
        }

        public void ClickOnResetButton()
        {
            util.ClickOnElement(locator.GetResetButtonLocator());
        }

        public string GetCustomerIDMessage()
        {
            return util.GetElementText(locator.GetCustomerIDMessageLocator());
        }

        public string EnterInvalidCharacterAndGetMessage(string characters)
        {
            SetCustomerID(characters);
            return GetCustomerIDMessage();
        }
    }
}
