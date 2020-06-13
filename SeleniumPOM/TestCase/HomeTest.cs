using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Config;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Actions;
using SeleniumPOM.BasePage;
using SeleniumPOM.TestContextClass;

namespace SeleniumPOM
{
    [TestClass]
    public class HomeTest : TestClassContext
    {
        #region Fields 

        IHomePage homerPage;
        ILoginPage loginPage;
        IConfig config;
        public const string PAGE = "HomePage$";

        #endregion

        [TestInitialize]
        public void SetUp()
        {
            Page.Initialization();
            config = new AppConfigReader();
            loginPage = new LoginPage();
            homerPage = loginPage.Login(config.GetUserName(), config.GetPassword());
        }

        [TestMethod]
        [DataSource(EXCEL_PROPERTIES, EXCEL_SHEET_LOCATION, PAGE, DataAccessMethod.Sequential)]
        public void VerifyWelcomeMessage()
        {
            extent.CreateTest(TestContext.TestName);
            Assert.AreEqual(homerPage.GetWelcomeMessage(), TestContext.DataRow["WelcomeMessage"]);
        }

        [TestMethod]
        [DataSource(EXCEL_PROPERTIES, EXCEL_SHEET_LOCATION, PAGE, DataAccessMethod.Sequential)]
        public void VerifyMangerID()
        {
            extent.CreateTest(TestContext.TestName);
            Assert.AreEqual(homerPage.GetManagerID(), TestContext.DataRow["ManegerID"]);
        }

        [TestCleanup]
        public void TearDown()
        {
            SetUpResults(TestContext.CurrentTestOutcome.ToString());
            Page.QuitSession();
        }
    }
}
