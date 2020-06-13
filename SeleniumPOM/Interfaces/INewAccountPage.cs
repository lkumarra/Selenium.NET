namespace SeleniumPOM.Interfaces
{
    interface INewAccountPage
    {

        /// <summary>
        /// Enter customer id on Customer Id field.
        /// </summary>
        /// <param name="CustomerId">Customer Id to enter</param>
        void SetCustomerID(string CustomerId);

        /// <summary>
        /// Select account type from dropdown.
        /// </summary>
        /// <param name="AccountType">Account type to select</param>
        void SelectAccountType(string AccountType);

        /// <summary>
        /// Set initial deposit amount in intial deposit field.
        /// </summary>
        /// <param name="Deposit">Deposit amount to enter</param>
        void SetInitialDeposit(string Deposit);

        /// <summary>
        /// Click on submit button.
        /// </summary>
        void ClickOnSubmitButton();

        /// <summary>
        /// Click on reset button.
        /// </summary>
        void ClickOnResetButton();

        /// <summary>
        /// Get the Customer Id Message.
        /// </summary>
        /// <returns>Customer Id Message</returns>
        string GetCustomerIDMessage();

        /// <summary>
        /// Enter invalid charaters and get the customer id message.
        /// </summary>
        /// <param name="characters">Invalid Characters to enter</param>
        /// <returns>Customer Id Message</returns>
        string EnterInvalidCharacterAndGetCustomerIDMessge(string characters);
    }
}
