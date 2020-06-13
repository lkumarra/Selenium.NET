namespace SeleniumPOM.Interfaces
{
    interface ICustomisedStatementPage
    {

        /// <summary>
        /// Enter Account Number into account number field.
        /// </summary>
        /// <param name="AccountNo">Account Number to enter</param>
        void SetAccountNumber(string AccountNo);

        /// <summary>
        /// Enter Date into from date filed.
        /// </summary>
        /// <param name="Date">Date to enter</param>
        void SetFromDate(string Date);

        /// <summary>
        /// Enter date into to date field.
        /// </summary>
        /// <param name="Date">Date to enter</param>
        void SetToDate(string Date);

        /// <summary>
        /// Enter transaction value into minimum transaction value field.
        /// </summary>
        /// <param name="Value">Value to enter</param>
        void SetMinimunTransactionValue(string Value);

        /// <summary>
        /// Enter number of transaction into number of transaction field.
        /// </summary>
        /// <param name="Number">Number of Transaction to enter</param>
        void SetNumberOfTransaction(string Number);

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
        /// <param name="Characters">Invalid Characters to enter</param>
        /// <returns>Account number message</returns>
        string EnterInvalidCharactersAndGetMessage(string Characters);

    }
}
