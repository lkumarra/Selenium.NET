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
    public class NewAccountTest : TestClassContext
    {
        ILoginPage loginPage;
        IConfig config;
        IHomePage homePage;
        INewAccountPage newAccountPage;

        [TestInitialize]
        public void Setup()
        {
            Page.Initialization();
            loginPage = new LoginPage();
            config = new AppConfigReader();
            homePage = loginPage.Login(config.GetUserName(), config.GetPassword());
            newAccountPage = homePage.ClickOnNewAccountPage();
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", EXCEL_SHEET_LOCATION, "NewAccount$", DataAccessMethod.Sequential)]
        public void VerifyCustomerIdMessage()
        {
            string ActualMessage = newAccountPage.EnterInvalidCharacterAndGetCustomerIDMessge(TestContext.DataRow["Data"].ToString());
            Assert.AreEqual(ActualMessage, TestContext.DataRow["ExpectedMessage"].ToString());
        }

        [TestCleanup]
        public void TearDown()
        {
            Page.QuitSession();
        }
    }
}
