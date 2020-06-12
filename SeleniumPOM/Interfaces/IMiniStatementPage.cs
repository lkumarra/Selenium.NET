using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Interfaces
{
    interface IMiniStatementPage
    {
        /// <summary>
        /// Enter Account Number into account number field.
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
        /// Get Account Number Message.
        /// </summary>
        /// <returns>Account Number Message</returns>
        string GetAccountNumberMessage();

        /// <summary>
        /// Enter invalid characters into account number field and get message.
        /// </summary>
        /// <param name="Characters">Invalid characters to enter</param>
        /// <returns>Account Number Message</returns>
        string EnterInvalidCharactersAndGetMessage(string Characters);
    }
}
