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
    class BalanceEnquiryPage : Page, IBalanceEnquiryPage
    {
        readonly IUtil util = new Utils();
        BalanceEnquiryLocator locator;

        public BalanceEnquiryPage()
        {
            locator = new BalanceEnquiryLocator();
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
    }
}
