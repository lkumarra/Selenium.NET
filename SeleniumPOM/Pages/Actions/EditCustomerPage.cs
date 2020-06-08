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
    class EditCustomerPage  : Page, IEditCostumerPage
    {
        readonly Utils util = new Utils();
        EditCostumerLocator locator;

        public EditCustomerPage()
        {
            locator = new EditCostumerLocator();
            PageFactory.InitElements(driver, locator);
            
        }

        public void SetCostumerID(string CostumerID)
        {
            util.EnterTextIntoElement(locator.GetCostumerIDLocator(), CostumerID);
        }

        public void ClickOnSubmitButton()
        {
            util.ClickOnElement(locator.GetSubmitButtonLocator());
        }

        public void ClickOnResetButton()
        {
            util.ClickOnElement(locator.GetResetButtonLocator());
        }

        public string GetCostumerIDMessage()
        {
            return util.GetElementText(locator.GetCustomerIDMessageLocator());
        }

        public string CustomerIDInvaildCharactersAndMessageText(string Characters)
        {
            SetCostumerID(Characters);
            return GetCostumerIDMessage();
        }

        public string GetCostumerIDAlertMessage()
        {
            return util.GetAlertTextAndAccept();
        }

    }
}
