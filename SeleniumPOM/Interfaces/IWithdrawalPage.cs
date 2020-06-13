namespace SeleniumPOM.Interfaces
{
    interface IWithdrawalPage
    {

        /// <summary>
        /// Enter account number in account number field.
        /// </summary>
        /// <param name="AccountNo">Account number to enter</param>
        void SetAccountNumber(string AccountNo);

        /// <summary>
        /// Enter amount in amount field.
        /// </summary>
        /// <param name="Amount">Amount to enter</param>
        void SetAmount(string Amount);

        /// <summary>
        /// Enter description in description field.
        /// </summary>
        /// <param name="Description">Description to enter</param>
        void SetDescription(string Description);

        /// <summary>
        /// Click on submit button
        /// </summary>
        void ClickOnSubmitButton();

        /// <summary>
        /// Click on reset button
        /// </summary>
        void ClickOnResetButton();

        /// <summary>
        /// Get Accont Number Message.
        /// </summary>
        /// <returns>Account Number Message</returns>
        string GetAccountNumberMessage();

        /// <summary>
        /// Enter invalid characters in account number field and get message.
        /// </summary>
        /// <param name="Characters">Invalid characters to enter</param>
        /// <returns>Account number message</returns>
        string EnterInvalidCharactersAndGetAccountNumberMessage(string Characters);
    }
}
