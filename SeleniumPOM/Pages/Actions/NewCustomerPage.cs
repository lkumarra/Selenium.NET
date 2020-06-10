using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.TestBase;
using SeleniumPOM.Utilities;

namespace SeleniumPOM.Pages.Actions
{
    class NewCustomerPage : Page, INewCostumerPage
    {

        readonly IUtil util = new Utils();
        NewCustomerLocators locators;

        public NewCustomerPage()
        {
            locators = new NewCustomerLocators();
            PageFactory.InitElements(driver, locators);
        }


        public void SetCustomerName(string CustomerName)
        {
            util.EnterTextIntoElement(locators.GetCustomerNameLocator(), CustomerName);
        }


        public void SelectMale()
        {
            util.ClickOnElement(locators.GetMaleRadioButtonLocator());
        }

        public void SelectFemale()
        {
            util.ClickOnElement(locators.GetFemaleRadioButtonLocator());
        }


        public void SetDateOfBirth(string DOB)
        {
            util.EnterTextIntoElement(locators.GetDOBLocator(), DOB);
        }


        public void SetAddress(string Address)
        {
            util.EnterTextIntoElement(locators.GetAddressLocator(), Address);
        }


        public void SetCity(string City)
        {
            util.EnterTextIntoElement(locators.GetCityLocator(), City);
        }

        public void SetState(string State)
        {
            util.EnterTextIntoElement(locators.GetStateLocator(), State);
        }

        public void SetPinCode(string PinCode)
        {
            util.EnterTextIntoElement(locators.GetPINLocator(), PinCode);
        }

        public void SetMobileNumber(string Mobile)
        {
            util.EnterTextIntoElement(locators.GetMobileLocator(), Mobile);
        }

        public void SetEmail(string Email)
        {
            util.EnterTextIntoElement(locators.GetEmailLocator(), Email);
        }

        public void SetPassword(string Password)
        {
            util.EnterTextIntoElement(locators.GetPasswordLocator(), Password);
        }

        public void ClickOnSubmitButton()
        {
            util.ClickOnElement(locators.GetSubmitButtonLocator());
        }

        public void ClickOnResetButton()
        {
            util.ClickOnElement(locators.GetResetButtonLocator());
        }

        public void addNewCustomer(string CustomerName, string Gender, string DOB, string Adress,
            string City, string State, string Pin, string MobileNumber, string Email, string Password)
        {
            SetCustomerName(CustomerName);
            if (Gender.Equals("Male"))
            {
                SelectMale();
            }
            else
            {
                SelectFemale();
            }
            SetDateOfBirth(DOB);
            SetAddress(Adress);
            SetCity(City);
            SetState(State);
            SetPinCode(Pin);
            SetMobileNumber(MobileNumber);
            SetEmail(Email);
            SetPassword(Password);
            ClickOnSubmitButton();
        }

        public string EnterInvalidCharacterInCustomerName(string Characters)
        {
            util.EnterTextIntoElement(locators.GetCustomerNameLocator(), Characters);
            return util.GetElementText(locators.GetCustomerNameMessageLocator());
        }

        public string EnterMaximumCharactersInCustomerName(string maxcharacters)
        {
            util.EnterTextIntoElement(locators.GetCustomerNameLocator(), maxcharacters);
            return util.GetElementAttribute(locators.GetCustomerNameLocator(), "value").Length.ToString();
        }

        public string CustomerNameBlankVerify()
        {
            util.ClickOnElement(locators.GetCustomerNameLocator());
            util.ClickOnElement(locators.GetDOBLocator());
            return util.GetElementText(locators.GetCustomerNameMessageLocator());
        }
    }
}
