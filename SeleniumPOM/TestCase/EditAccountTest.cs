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
    public class EditAccountTest : TestClassContext
    {
        ILoginPage loginPage;
        IConfig config;
        IHomePage homePage;
        IEditAccountPage editAccountPage;

        [TestInitialize]
        public void Setup()
        {
            Page.Initialization();
            loginPage = new LoginPage();
            config = new AppConfigReader();
            homePage = loginPage.Login(config.GetUserName(), config.GetPassword());
            editAccountPage = homePage.ClickOnEditAccountPage();
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", @"Dsn = Excel Files;dbq=C:\Users\Lavendra rajput\source\repos\SeleniumPOM\SeleniumPOM\TestData\Guru99Bank.xlsx;", "EditAccount$", DataAccessMethod.Sequential)]
        public void VerifyAccountNumberMessage()
        {
            string ActualMessage = editAccountPage.EnterInvalidCharactersAndGetMessage(TestContext.DataRow["Data"].ToString());
            Assert.AreEqual(ActualMessage, TestContext.DataRow["ExpectedMessage"].ToString());
        }

        [TestCleanup]
        public void TearDown()
        {
            Page.QuitSession();
        }
    }
}
