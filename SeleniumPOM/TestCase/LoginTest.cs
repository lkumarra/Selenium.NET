using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Config;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Actions;
using SeleniumPOM.TestBase;
using SeleniumPOM.TestContextClass;

namespace SeleniumPOM
{
    [TestClass]
    public class LoginTest : TestClassContext
    {
        ILoginPage loginPage;
        IConfig config;
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
            Console.WriteLine("Test Case Name :{0}", TestContext.TestName);
            loginPage.Login(config.GetUserName(), config.GetPassword());
        }

        [TestCleanup]
        public void TearDown()
        {
            Console.WriteLine("Result :{0}", TestContext.CurrentTestOutcome);
            Page.QuitSession();
        }
    }
}
