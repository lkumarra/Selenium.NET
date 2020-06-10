namespace SeleniumPOM.Interfaces
{
    interface IEditCostumerPage
    {
        /// <summary>
        /// Set customer id on Edit Customer page.
        /// </summary>
        /// <param name="CostumerID">Customer id to enter</param>
        void SetCostumerID(string CostumerID);

        /// <summary>
        /// Click on Submit Button.
        /// </summary>
        void ClickOnSubmitButton();

        /// <summary>
        /// Click on Reset Button.
        /// </summary>
        void ClickOnResetButton();

        /// <summary>
        /// Get Customer Id Message.
        /// </summary>
        /// <returns>Meaasge By entering customer id</returns>
        string GetCostumerIDMessage();

        /// <summary>
        /// Get Customer Id message by entering invalid characters.
        /// </summary>
        /// <param name="Characters">Invalid characters to entered</param>
        /// <returns>Message after entering invalid characters</returns>
        string CustomerIDInvaildCharactersAndMessageText(string Characters);

        /// <summary>
        /// Get Alert Message.
        /// </summary>
        /// <returns>Alert Message</returns>
        string GetCostumerIDAlertMessage();
    }
}
