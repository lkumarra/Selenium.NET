using log4net;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Locators;
using SeleniumPOM.BasePage;
using SeleniumPOM.Utilities;
using System.Threading;

namespace SeleniumPOM.Pages.Actions
{
    class NewCustomerPage : Page, INewCostumerPage
    {
        #region objects

        readonly ILog logger = Log4NetHelper.GetLogger(typeof(NewCustomerPage));
        readonly IUtil util = new Utils();
        NewCustomerLocators locators;

        #endregion

        public NewCustomerPage()
        {
            locators = new NewCustomerLocators();
            PageFactory.InitElements(driver, locators);
        }


        public void SetCustomerName(string CustomerName)
        {
            util.EnterTextIntoElement(locators.GetCustomerNameLocator(), CustomerName);
            logger.Info("Customer Name Entered is : " + CustomerName);
        }


        public void SelectMale()
        {
            util.ClickOnElement(locators.GetMaleRadioButtonLocator());
            logger.Info("Male option is selected");
        }

        public void SelectFemale()
        {
            util.ClickOnElement(locators.GetFemaleRadioButtonLocator());
            logger.Info("Female option is selected");
        }


        public void SetDateOfBirth(string DOB)
        {
            util.EnterTextIntoElement(locators.GetDOBLocator(), DOB);
            logger.Info("Date of Birth entered is : " + DOB);
        }

        public void SetAddress(string Address)
        {
            util.EnterTextIntoElement(locators.GetAddressLocator(), Address);
            logger.Info("Address entered is : " + Address);
        }


        public void SetCity(string City)
        {
            util.EnterTextIntoElement(locators.GetCityLocator(), City);
            logger.Info("City entered is : " + City);
        }

        public void SetState(string State)
        {
            util.EnterTextIntoElement(locators.GetStateLocator(), State);
            logger.Info("State entered is : " + State);
        }

        public void SetPinCode(string PinCode)
        {
            util.EnterTextIntoElement(locators.GetPINLocator(), PinCode);
            logger.Info("PinCode entered is : " + PinCode);
        }

        public void SetMobileNumber(string Mobile)
        {
            util.EnterTextIntoElement(locators.GetMobileLocator(), Mobile);
            logger.Info("MobileNo entered is : " + Mobile);
        }

        public void SetEmail(string Email)
        {
            util.EnterTextIntoElement(locators.GetEmailLocator(), Email);
            logger.Info("Email entered is : " + Email);
        }

        public void SetPassword(string Password)
        {
            util.EnterTextIntoElement(locators.GetPasswordLocator(), Password);
            logger.Info("Password entered is : " + Password);
        }

        public void ClickOnSubmitButton()
        {
            util.ClickOnElement(locators.GetSubmitButtonLocator());
            logger.Info("Clicked on Submit Button");
        }

        public void ClickOnResetButton()
        {
            util.ClickOnElement(locators.GetResetButtonLocator());
            logger.Info("Clicked on Reset Button");
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
            string Text = util.GetElementText(locators.GetCustomerNameMessageLocator());
            logger.Info("Customer Name Message is : " + Text);
            return Text;
        }

        public string EnterMaximumCharactersInCustomerName(string maxcharacters)
        {
            util.EnterTextIntoElement(locators.GetCustomerNameLocator(), maxcharacters);
            Thread.Sleep(1000);
            string Length = util.GetElementAttribute(locators.GetCustomerNameLocator(), "value").Length.ToString();
            logger.Info("Length of characters is : " + Length);
            return Length;
        }

        public string CustomerNameBlankVerify()
        {
            util.ClickOnElement(locators.GetCustomerNameLocator());
            util.ClickOnElement(locators.GetDOBLocator());
            string Text = util.GetElementText(locators.GetCustomerNameMessageLocator());
            logger.Info("Customer Name Message is : " + Text);
            return Text;
        }
    }
}
