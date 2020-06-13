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
    public class NewAccountTest : TestClassContext
    {
        #region Fields

        ILoginPage loginPage;
        IConfig config;
        IHomePage homePage;
        INewAccountPage newAccountPage;
        public const string PAGE = "NewAccount$";

        #endregion

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
        [DataSource(EXCEL_PROPERTIES, EXCEL_SHEET_LOCATION, PAGE, DataAccessMethod.Sequential)]
        public void VerifyCustomerIdMessage()
        {
            extent.CreateTest(TestContext.TestName);
            string ActualMessage = newAccountPage.EnterInvalidCharacterAndGetCustomerIDMessge(TestContext.DataRow["Data"].ToString());
            Assert.AreEqual(ActualMessage, TestContext.DataRow["ExpectedMessage"].ToString());
        }

        [TestCleanup]
        public void TearDown()
        {
            SetUpResults(TestContext.CurrentTestOutcome.ToString());
            Page.QuitSession();
        }
    }
}
