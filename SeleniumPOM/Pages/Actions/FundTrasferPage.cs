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
    class FundTrasferPage : Page, IFundTransferPage
    {
        readonly IUtil util = new Utils();
        FundTrasferLocator locator;

        public FundTrasferPage()
        {
            locator = new FundTrasferLocator();
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

        public string EnterInvalidCharactersAndGetPayersAccountMessage(string Characters)
        {
            SetPayersAccountNumber(Characters);
            return GetPayersAccountNumberMessage();
        }

        public string GetPayersAccountNumberMessage()
        {
            return util.GetElementText(locator.GetPayersAccountMessageLocator());
        }

        public void SetAmount(string Amount)
        {
            util.EnterTextIntoElement(locator.GetAmountLocator(), Amount);
        }

        public void SetDescription(string Description)
        {
            util.EnterTextIntoElement(locator.GetDescriptionLocator(), Description);
        }

        public void SetPayeesAccountNumber(string AccountNo)
        {
            util.EnterTextIntoElement(locator.GetPayessAccNoLocator(), AccountNo);
        }

        public void SetPayersAccountNumber(string AccountNo)
        {
            util.EnterTextIntoElement(locator.GetPayersAccNoLocator(), AccountNo);
        }
    }
}
