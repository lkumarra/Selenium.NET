using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Interfaces
{
    interface IDeleteCustomerPage
    {
        /// <summary>
        /// Enter Cutomer Id On Customer Id Field.
        /// </summary>
        /// <param name="CustomerID">Customer id to enter</param>
        void SetCustomerID(string CustomerID);

        /// <summary>
        /// Click on Submit Button.
        /// </summary>
        void ClickOnSubmitButton();

        /// <summary>
        /// Click on Reset Button.
        /// </summary>
        void ClickOnResetButton();

        /// <summary>
        /// Get the CustomerId Message.
        /// </summary>
        /// <returns></returns>
        string GetCustomerIDMessage();

        /// <summary>
        /// Enter invalid characters in customer id field and get the message text.
        /// </summary>
        /// <param name="characters">Invalid Characters to enter</param>
        /// <returns>Return the Customer Id Message </returns>
        string EnterInvalidCharacterAndGetMessage(string characters);

    }
}
