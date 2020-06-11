using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Pages.Locators
{
    class CustomisedStatementLocator
    {

        [FindsBy(How = How.Name, Using = "accountno")]
        private IWebElement AccountNo { get; set; }

        [FindsBy(How = How.Name, Using = "fdate")]
        private IWebElement FromDate { get; set; }

        [FindsBy(How = How.Name, Using = "tdate")]
        private IWebElement ToDate { get; set; }

        [FindsBy(How = How.Name, Using = "amountlowerlimit")]
        private IWebElement MinimumTransactionValue { get; set; }

        [FindsBy(How = How.Name, Using = "numtransaction")]
        private IWebElement NumberOfTransaction { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.Name, Using = "res")]
        private IWebElement ResetButton { get; set; }

        /// <summary>
        /// Retun the locator of account number field on CustomisedStatement Page.
        /// </summary>
        /// <returns>Locator of account number filed</returns>
        public IWebElement GetAccountNumberLocator()
        {
            return AccountNo;
        }

        /// <summary>
        /// Return the locator of FromDate field in Customised Statement Page.
        /// </summary>
        /// <returns>Locator of FroDate field </returns>
        public IWebElement GetFromDateLocator()
        {
            return FromDate;
        }

        /// <summary>
        /// Return the locator of To Date field on Customised statement page.
        /// </summary>
        /// <returns>Locator of to date field</returns>
        public IWebElement GetToDateLocator()
        {
            return ToDate;
        }

        /// <summary>
        /// Return the locator of Minimum Transaction Value on CustomisedStatement Page.
        /// </summary>
        /// <returns>Locator of Minimum Transaction Value</returns>
        public IWebElement GetMinimumTransactionValueLocator()
        {
            return MinimumTransactionValue;
        }

        /// <summary>
        /// Return the locator of Number of Transaction on CustomisedStatement Page.
        /// </summary>
        /// <returns>Locator of Number of Transaction field</returns>
        public IWebElement GetNumberOfTransactionLocator()
        {
            return NumberOfTransaction;
        }

        /// <summary>
        /// Return the Locator of Submit Button on CustomisedStatement page. 
        /// </summary>
        /// <returns>Locator of Submit Button</returns>
        public IWebElement GetSubmitButtonLocator()
        {
            return SubmitButton;
        }

        /// <summary>
        /// Return the Locator of Reset Button on CustomisedStatement page. 
        /// </summary>
        /// <returns>Locator of Reset Button</returns>
        public IWebElement GetResetButtonLocator()
        {
            return ResetButton;
        }

    }
}
