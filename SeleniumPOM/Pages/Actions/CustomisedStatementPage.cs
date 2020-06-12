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
    class CustomisedStatementPage : Page, ICustomisedStatementPage
    {
        readonly IUtil util = new Utils();
        CustomisedStatementLocator locator;

        public CustomisedStatementPage()
        {
            locator = new CustomisedStatementLocator();
            PageFactory.InitElements(driver, locator);
        }

        public void ClickOnResetButton()
        {
            util.ClickOnElement(locator.GetResetButtonLocator());
        }

        public void ClickOnSubmitButton()
        {
            util.ClickOnElement(locator.GetSubmitButtonLocator());
        }

        public string EnterInvalidCharactersAndGetMessage(string Characters)
        {
            SetAccountNumber(Characters);
            return GetAccountNumberMessage();
        }

        public string GetAccountNumberMessage()
        {
            return util.GetElementText(locator.GetAccountNumberMessageLocator());
        }

        public void SetAccountNumber(string AccountNo)
        {
            util.EnterTextIntoElement(locator.GetAccountNumberLocator(), AccountNo);
        }

        public void SetFromDate(string Date)
        {
            util.EnterTextIntoElement(locator.GetFromDateLocator(), Date);
        }

        public void SetMinimunTransactionValue(string Value)
        {
            util.EnterTextIntoElement(locator.GetMinimumTransactionValueLocator(), Value);
        }

        public void SetNumberOfTransaction(string Number)
        {
            util.EnterTextIntoElement(locator.GetNumberOfTransactionLocator(), Number);
        }

        public void SetToDate(string Date)
        {
            util.EnterTextIntoElement(locator.GetToDateLocator(), Date);
        }
    }
}
