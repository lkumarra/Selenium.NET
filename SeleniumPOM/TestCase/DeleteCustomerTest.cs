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
    public class DeleteCustomerTest : TestClassContext
    {
        ILoginPage loginPage;
        IConfig config;
        IHomePage homePage;
        IDeleteCustomerPage deleteCustomerPage;

        [TestInitialize]
        public void SetUp()
        {
            Page.Initialization();
            config = new AppConfigReader();
            loginPage = new LoginPage();
            homePage = loginPage.Login(config.GetUserName(), config.GetPassword());
            deleteCustomerPage = homePage.ClickOnDeleteCustomerPage();
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", EXCEL_SHEET_LOCATION, "DeleteCustomer$", DataAccessMethod.Sequential)]
        public void VerifyCustomerIdMessage()
        {
            string ActualMessage = deleteCustomerPage.EnterInvalidCharacterAndGetMessage(TestContext.DataRow["Data"].ToString());
            Assert.AreEqual(ActualMessage, TestContext.DataRow["ExpectedMessage"].ToString());
        }

        [TestCleanup]
        public void TearDown()
        {
            Page.QuitSession();
        }
    }
}
