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
    public class LoginTest : TestClassContext
    {
        #region Fields

        ILoginPage loginPage;
        IConfig config;

        #endregion

        [TestInitialize]
        public void SetUp()
        {
            Page.Initialization();
            config = new AppConfigReader();
            loginPage = new LoginPage();
        }

        [TestMethod]
        public void VerifyLogin()
        {
            extent.CreateTest(TestContext.TestName);
            loginPage.Login(config.GetUserName(), config.GetPassword());
        }

        [TestCleanup]
        public void TearDown()
        {
            SetUpResults(TestContext.CurrentTestOutcome.ToString());
            Page.QuitSession();
        }
    }
}
