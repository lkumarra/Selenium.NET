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
    public class NewCustomerTest : TestClassContext
    {
        ILoginPage loginPage;
        IConfig config;
        IHomePage homePage;
        INewCostumerPage newCostumerPage;

        [TestInitialize]
        public void SetUp()
        {
            Page.Initialization();
            loginPage = new LoginPage();
            config = new AppConfigReader();
            homePage = loginPage.Login(config.GetUserName(), config.GetPassword());
            newCostumerPage = homePage.ClickOnNewCustomerLink();
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", EXCEL_SHEET_LOCATION, "NewCustomerPage$", DataAccessMethod.Sequential)]
        public void VerifyCustomerNameByEnteringNumbers()
        {
            string ActualMessage = newCostumerPage.EnterInvalidCharacterInCustomerName(TestContext.DataRow["Data"].ToString());
            Assert.AreEqual(ActualMessage, TestContext.DataRow["ExpectedMessage"].ToString());
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", EXCEL_SHEET_LOCATION, "NewCustomerPage$", DataAccessMethod.Sequential)]
        public void VerifyCustomerNameMaxCharactersLength()
        {
            string ActualMessage = newCostumerPage.EnterMaximumCharactersInCustomerName(TestContext.DataRow["MaxCharacter"].ToString());
            Assert.AreEqual(ActualMessage, TestContext.DataRow["Length"].ToString());
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", EXCEL_SHEET_LOCATION, "NewCustomerPage$", DataAccessMethod.Sequential)]
        public void VerifyCustomerNameWithoutEnteringValue()
        {
            string ActualMessage = newCostumerPage.CustomerNameBlankVerify();
            Assert.AreEqual(ActualMessage, TestContext.DataRow["BlankMessage"].ToString());
        }

        [TestCleanup]
        public void TearDown()
        {
            Page.QuitSession();
        }
    }
}
