using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Pages.Actions;
using SeleniumPOM.TestBase;

namespace SeleniumPOM
{
    [TestClass]
    public class HomeTest
    {
        HomePage homerPage;
        LoginPage loginPage;

        [TestInitialize]
        public void SetUp()
        {
            Page.Initialization();
            loginPage = new LoginPage();
            homerPage = loginPage.Login(Constants.UserName, Constants.Password);
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
