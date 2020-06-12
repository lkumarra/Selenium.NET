using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Interfaces
{
    interface IFundTransferPage
    {

        /// <summary>
        /// Enter PayersAccountNumber on PayersAccount field.
        /// </summary>
        /// <param name="AccountNo">Account Number to enter</param>
        void SetPayersAccountNumber(string AccountNo);

        /// <summary>
        /// Enter PayeesAccountNumber on PayeesAccount field.
        /// </summary>
        /// <param name="AccountNo">Account Number to enter</param>
        void SetPayeesAccountNumber(string AccountNo);

        /// <summary>
        /// Enter amount on amount field.
        /// </summary>
        /// <param name="Amount">Amount to enter</param>
        void SetAmount(string Amount);

        /// <summary>
        /// Enter description to description field.
        /// </summary>
        /// <param name="Description">Description to enter</param>
        void SetDescription(string Description);

        /// <summary>
        /// Click on Submit Button.
        /// </summary>
        void ClickOnSubmitButton();

        /// <summary>
        /// Click on Reset Button.
        /// </summary>
        void ClickOnResetButton();

        /// <summary>
        /// Get Payers Account Number Message.
        /// </summary>
        /// <returns>Payers Account Number Message</returns>
        string GetPayersAccountNumberMessage();

        /// <summary>
        /// Enter invalid characters to Payers Account Number Field and Get Message.
        /// </summary>
        /// <param name="Characters">Invalid characters to enter</param>
        /// <returns>Payers Account Number Message</returns>
        string EnterInvalidCharactersAndGetPayersAccountMessage(string Characters);
    }
}
