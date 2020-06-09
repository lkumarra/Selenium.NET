using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Pages.Locators
{
    class EditCostumerLocator
    {
        [FindsBy(How = How.Name, Using = "cusid")]
        private IWebElement CosutumerId { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        [FindsBy(How = How.Id, Using = "message14")]
        private IWebElement CustomerIDMessage { get; set; }

        public IWebElement GetCostumerIDLocator()
        {
            return CosutumerId;
        }

        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }

        public IWebElement GetCustomerIDMessageLocator()
        {
            return CustomerIDMessage;
        }

     
    }
}
