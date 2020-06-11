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

        NewCustomerLocators locators;
        readonly IUtil util = new Utils();

        public NewAccountPage()
        {
            locators = new NewCustomerLocators();
            PageFactory.InitElements(driver, locators)
        }

        public void SetCustomerID(string CustomerId)
        {

        }

        public void SelectAccountType(string AccountType)
        {

        }

        public void SetInitialDeposit(string Deposit)
        {

        }

        public void ClickOnSubmitButton()
        {

        }

        public void ClickOnResetButton()
        {

        }

        public string GetCustomerIDMessage()
        {

        }

        public string EnterInvalidCharacterAndGetCustomerIDMessge(string characters)
        {

        }

    }
}
