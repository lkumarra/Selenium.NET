using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Config;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Actions;
using SeleniumPOM.BasePage;
using SeleniumPOM.TestContextClass;

namespace SeleniumPOM.TestCase
{
    [TestClass]
    public class WithdrawalTest : TestClassContext
    {
        #region Fields

        ILoginPage loginPage;
        IConfig config;
        IHomePage homePage;
        IWithdrawalPage withdrawalPage;
        public const string PAGE = "Withdrawal$";

        #endregion

        [TestInitialize]
        public void Setup()
        {
            Page.Initialization();
            loginPage = new LoginPage();
            config = new AppConfigReader();
            homePage = loginPage.Login(config.GetUserName(), config.GetPassword());
            withdrawalPage = homePage.ClickOnWithdrawalPage();
        }

        [TestMethod]
        [DataSource(EXCEL_PROPERTIES, EXCEL_SHEET_LOCATION, PAGE, DataAccessMethod.Sequential)]
        public void VerifyAccountNumberMessage()
        {
            extent.CreateTest(TestContext.TestName);
            string ActualMessage = withdrawalPage.EnterInvalidCharactersAndGetAccountNumberMessage(TestContext.DataRow["Data"].ToString());
            Assert.AreEqual(ActualMessage, TestContext.DataRow["ExpectedMessage"]);
        }

        [TestCleanup]
        public void TearDown()
        {
            SetUpResults(TestContext.CurrentTestOutcome.ToString());
            Page.QuitSession();
        }
    }
}
