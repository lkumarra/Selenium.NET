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

        /// <summary>
        /// Click on DeleteCustomer Link.
        /// </summary>
        /// <returns>Object of DeleteCuctomer Page</returns>
        DeleteCustomerPage ClickOnDeleteCustomerPage();

        /// <summary>
        /// Click on NewAccount Link.
        /// </summary>
        /// <returns>Object of NewAccount Page</returns>
        NewAccountPage ClickOnNewAccountPage();

        /// <summary>
        /// Click On EditAccount Link.
        /// </summary>
        /// <returns>Object of EditAccount Page</returns>
        EditAccountPage ClickOnEditAccountPage();

        /// <summary>
        /// Click on DeleteAccount Link.
        /// </summary>
        /// <returns>Object of DeleteAccount Page</returns>
        DeleteAccountPage ClickOnDeleteAccountPage();

        /// <summary>
        /// Click on Deposit Link.
        /// </summary>
        /// <returns>Object of Deposit Page</returns>
        DepositPage ClickOnDepositPage();

        /// <summary>
        /// Click on Withdrawal Link.
        /// </summary>
        /// <returns>Object of Withdrawal Page</returns>
        WithdrawalPage ClickOnWithdrawalPage();

        /// <summary>
        /// Click on FundTransfer Link.
        /// </summary>
        /// <returns>Object of Fundtransfer Page</returns>
        FundTrasferPage ClickOnFundTransferPage();

        /// <summary>
        /// Click on BalanceEnquiry Link.
        /// </summary>
        /// <returns>Object of BalanceEnquiry Page</returns>
        BalanceEnquiryPage ClickOnBalanceEnquiryPage();

        /// <summary>
        /// Click on MiniStatement Link.
        /// </summary>
        /// <returns>Object of MiniStatement Page</returns>
        MiniStatementPage ClickOnMiniSatatementPage();

        /// <summary>
        /// Click on CustomisedStatement Link.
        /// </summary>
        /// <returns>object of CustomisedStatement Page</returns>
        CustomisedStatementPage ClickOnCustomisedStatementPage();

    }
}
