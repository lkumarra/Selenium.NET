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
    class NewAccountPage : Page, INewAccountPage
    {

        NewAccountLocator locators;
        readonly IUtil util = new Utils();

        public NewAccountPage()
        {
            locators = new NewAccountLocator();
            PageFactory.InitElements(driver, locators);
        }

        public void SetCustomerID(string CustomerId)
        {
            util.EnterTextIntoElement(locators.GetCustomerIDLocator(), CustomerId);
        }

        public void SelectAccountType(string AccountType)
        {
            util.SelectByVisibleText(locators.GetAccountTypeLocator(), AccountType);
        }

        public void SetInitialDeposit(string Deposit)
        {
            util.EnterTextIntoElement(locators.GetInitialDepositLocator(), Deposit);
        }

        public void ClickOnSubmitButton()
        {
            util.ClickOnElement(locators.GetSubmitButtonLocator());
        }

        public void ClickOnResetButton()
        {
            util.ClickOnElement(locators.GetResetButtonLocator());
        }

        public string GetCustomerIDMessage()
        {
            return util.GetElementText(locators.GetCustomerIDMessageLocator());
        }

        public string EnterInvalidCharacterAndGetCustomerIDMessge(string characters)
        {
            SetCustomerID(characters);
            return GetCustomerIDMessage();
        }

    }
}
