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
    public class HomeTest : TestClassContext
    {
        IHomePage homerPage;
        ILoginPage loginPage;
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
        [DataSource("System.Data.Odbc", @"Dsn = Excel Files;dbq=C:\Users\Lavendra rajput\source\repos\SeleniumPOM\SeleniumPOM\TestData\Guru99Bank.xlsx;", "HomePage$", DataAccessMethod.Sequential)]
        public void VerifyWelcomeMessage()
        {
            Console.WriteLine("Test Case Name :{0}", TestContext.TestName);
            Assert.AreEqual(homerPage.GetWelcomeMessage(), TestContext.DataRow["WelcomeMessage"]);
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", @"Dsn = Excel Files;dbq=C:\Users\Lavendra rajput\source\repos\SeleniumPOM\SeleniumPOM\TestData\Guru99Bank.xlsx;", "HomePage$", DataAccessMethod.Sequential)]
        public void VerifyMangerID()
        {
            Console.WriteLine("Test Case Name :{0}", TestContext.TestName);
            Assert.AreEqual(homerPage.GetManagerID(), TestContext.DataRow["ManegerID"]);
        }

        [TestCleanup]
        public void TearDown()
        {
            Console.WriteLine("Resuult :{0}", TestContext.CurrentTestOutcome);
            Page.QuitSession();
        }
    }
}
