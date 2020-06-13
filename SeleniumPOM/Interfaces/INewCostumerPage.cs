namespace SeleniumPOM.Interfaces
{
    interface INewCostumerPage
    {

        /// <summary>
        /// Set Customer Name on Customer Name Field.
        /// </summary>
        /// <param name="CustomerName">Name of the customer to add customer</param>
        void SetCustomerName(string CustomerName);

        /// <summary>
        /// Click on Male Radio Button on NewCustomer Page.
        /// </summary>
        void SelectMale();

        /// <summary>
        /// Click on Female Radio Button on NewCustomer Page.
        /// </summary>
        void SelectFemale();

        /// <summary>
        /// Set Date of Birth on NewCustomer Page.
        /// </summary>
        /// <param name="DOB">Date of Birth to add customer</param>
        void SetDateOfBirth(string DOB);

        /// <summary>
        /// Set Address on NewCustomer Page.
        /// </summary>
        /// <param name="address">Address to add Customer</param>
        void SetAddress(string Address);

        /// <summary>
        /// Set City on NewCustomer Page.
        /// </summary>
        /// <param name="City">City to add Customer</param>
        void SetCity(string City);

        /// <summary>
        /// Set State on NewCustomer Page.
        /// </summary>
        /// <param name="State">State to add Customer</param>
        void SetState(string State);

        /// <summary>
        /// Set Pin code to add customer.
        /// </summary>
        /// <param name="PinCode">PinCode to add Customer</param>
        void SetPinCode(string PinCode);

        /// <summary>
        /// Set Mobile Number to Add Customer.
        /// </summary>
        /// <param name="Mobile">Mobile number to add Customer</param>
        void SetMobileNumber(string Mobile);

        /// <summary>
        /// Set email to add Customer.
        /// </summary>
        /// <param name="Email">Email to add Customer</param>
        void SetEmail(string Email);

        /// <summary>
        /// Set Password to Add Customer
        /// </summary>
        /// <param name="Password">Password to add Customer</param>
        void SetPassword(string Password);

        /// <summary>
        /// Click on Submit Button 
        /// </summary>
        void ClickOnSubmitButton();

        /// <summary>
        /// Click on Reset Button 
        /// </summary>
        void ClickOnResetButton();

        /// <summary>
        /// Add customer by filling all required details.
        /// </summary>
        /// <param name="CustomerName">Name of the Customer</param>
        /// <param name="Gender">Gender of Customer</param>
        /// <param name="DOB">DOB of Customer</param>
        /// <param name="Adress">Address of Customer</param>
        /// <param name="City">City of Customer</param>
        /// <param name="State">State of Customer</param>
        /// <param name="Pin">Pin code of Customer</param>
        /// <param name="MobileNumber">Mobile Number of Customer</param>
        /// <param name="Email">Email of Customer</param>
        /// <param name="Password">Password of Customer</param>
        void addNewCustomer(string CustomerName, string Gender, string DOB, string Adress,
            string City, string State, string Pin, string MobileNumber, string Email, string Password);

        /// <summary>
        /// Enter invalid characters in Customer Name field and get message.
        /// </summary>
        /// <param name="Characters">Invalid Characters</param>
        /// <returns>Message by entering invalid character</returns>
        string EnterInvalidCharacterInCustomerName(string Characters);

        /// <summary>
        /// Enter Maximaum Characters in the Customer Name filed
        /// </summary>
        /// <param name="maxcharacters">Maximum Characters</param>
        /// <returns>Length of characters</returns>
        string EnterMaximumCharactersInCustomerName(string maxcharacters);

        /// <summary>
        /// Get Customer Name field without enterina any value
        /// </summary>
        /// <returns>Message of Customer name field</returns>
        string CustomerNameBlankVerify();

    }
}
