using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Config;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Actions;
using SeleniumPOM.TestBase;
using SeleniumPOM.TestContextClass;

namespace SeleniumPOM.TestCase
{
    [TestClass]
    public class WithdrawalTest : TestClassContext
    {
        ILoginPage loginPage;
        IConfig config;
        IHomePage homePage;
        IWithdrawalPage withdrawalPage;

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
        [DataSource("System.Data.Odbc", @"Dsn = Excel Files;dbq=C:\Users\Lavendra rajput\source\repos\SeleniumPOM\SeleniumPOM\TestData\Guru99Bank.xlsx;", "Withdrawal$", DataAccessMethod.Sequential)]
        public void VerifyAccountNumberMessage()
        {
            string ActualMessage = withdrawalPage.EnterInvalidCharactersAndGetAccountNumberMessage(TestContext.DataRow["Data"].ToString());
            Assert.AreEqual(ActualMessage, TestContext.DataRow["ExpectedMessge"]);
        }

        [TestCleanup]
        public void TearDown()
        {
            Page.QuitSession();
        }
    }
}
