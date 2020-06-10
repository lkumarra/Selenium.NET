using SeleniumPOM.Pages.Actions;


namespace SeleniumPOM.Interfaces
{
    interface IHomePage
    {

        /// <summary>
        /// Get the text of welcome message after login.
        /// </summary>
        /// <returns>Welcome message text</returns>
        string GetWelcomeMessage();

        /// <summary>
        /// Get the manager id after login.
        /// </summary>
        /// <returns>Manager id</returns>
        string GetManagerID();

        /// <summary>
        /// Click on New CustomerLink.
        /// </summary>
        /// <returns>Objcet of NewCustomer Page</returns>
        NewCustomerPage ClickOnNewCustomerLink();

        /// <summary>
        /// Click on EditCustomer Link.
        /// </summary>
        /// <returns>Object of EditCustomer Page</returns>
        EditCustomerPage ClickOnEditCustomerPage();
        
    }
}
