using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Pages.Actions;
using SeleniumPOM.TestBase;

namespace SeleniumPOM
{
    [TestClass]
    public class LoginTest
    {
        LoginPage loginPage;
        [TestInitialize]
        public void SetUp()
        {
            Page.Initialization();
            loginPage = new LoginPage();
        }

        [TestMethod]
        public void VerifyLogin()
        {
            loginPage.Login("mngr261615", "jEmUhub");
        }

        [TestCleanup]
        public void TearDown()
        {
            Page.QuitSession();
        }
    }
}
