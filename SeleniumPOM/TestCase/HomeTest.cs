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
    public class HomeTest
    {
        HomePage homerPage;
        LoginPage loginPage;
        IConfig config;
        [TestInitialize]
        public void SetUp()
        {
            Page.Initialization();
            config = new AppConfigReader();
            loginPage = new LoginPage();
            homerPage = loginPage.Login(config.GetUserName(), config.GetPassword());
        }

        [TestMethod]
        public void VerifyWelcomeMessage()
        {

            Assert.AreEqual(homerPage.GetWelcomeMessage(), "Welcome To Manager's Page of Guru99 Bank");
        }

        [TestMethod]
        public void VerifyMangerID()
        {
            Assert.AreEqual(homerPage.GetManagerID(), "Manger Id : mngr261615");
        }

        [TestCleanup]
        public void TearDown()
        {
            Page.QuitSession();
        }
    }
}
