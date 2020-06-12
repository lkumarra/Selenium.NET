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
    class WithdrawalPage : Page, IWithdrawalPage
    {
        readonly IUtil util = new Utils();
        WithdrawalLocator locator;

        public WithdrawalPage()
        {
            locator = new WithdrawalLocator();
            PageFactory.InitElements(driver, locator);
        }

        public void SetAccountNumber(string AccountNo)
        {
            util.EnterTextIntoElement(locator.GetAccountNumberLocator(), AccountNo);
        }

        public void SetAmount(string Amount)
        {
            util.EnterTextIntoElement(locator.GetAmountLocator(), Amount);
        }

        public void SetDescription(string Description)
        {
            util.EnterTextIntoElement(locator.GetDescriptionLocator(), Description);
        }

        public void ClickOnSubmitButton()
        {
            util.ClickOnElement(locator.GetSubmitButtonLocator());
        }

        public void ClickOnResetButton()
        {
            util.ClickOnElement(locator.GetResetButtonLocator());
        }

        public string GetAccountNumberMessage()
        {
            return util.GetElementText(locator.GetAccountNumberMessage());
        }

        public string EnterInvalidCharactersAndGetAccountNumberMessage(string Characters)
        {
            SetAccountNumber(Characters);
            return GetAccountNumberMessage();
        }
    }
}
