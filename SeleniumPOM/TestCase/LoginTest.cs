using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Config;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Actions;
using SeleniumPOM.TestBase;

namespace SeleniumPOM
{
    [TestClass]
    public class LoginTest
    {
        LoginPage loginPage;
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
            loginPage.Login(config.GetUserName(), config.GetPassword());
        }

        [TestCleanup]
        public void TearDown()
        {
            Page.QuitSession();
        }
    }
}
