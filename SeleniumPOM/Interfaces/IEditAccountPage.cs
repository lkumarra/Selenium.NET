using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Interfaces
{
    interface IEditAccountPage
    {

        /// <summary>
        /// Enter account number in account number field.
        /// </summary>
        /// <param name="AccountNo">Account number to enter</param>
        void SetAccountNumber(string AccountNo);

        /// <summary>
        /// Click on Submit Button.
        /// </summary>
        void ClickOnSubmitButton();

        /// <summary>
        /// Click on Reset Button.
        /// </summary>
        void ClickOnResetButton();

        /// <summary>
        /// Get account number message.
        /// </summary>
        /// <returns>Account number message</returns>
        string GetAccountNumberMessage();

        /// <summary>
        /// Enter invalid characters and get account number message.
        /// </summary>
        /// <param name="Characters">Invalid charactes to enter</param>
        /// <returns>Account number message</returns>
        string EnterInvalidCharactersAndGetMessage(string Characters);
    }
}
