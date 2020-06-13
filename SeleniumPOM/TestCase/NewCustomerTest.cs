using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Config;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Actions;
using SeleniumPOM.BasePage;
using SeleniumPOM.TestContextClass;

namespace SeleniumPOM.TestCase
{
    [TestClass]
    public class NewCustomerTest : TestClassContext
    {
        #region Fields

        ILoginPage loginPage;
        IConfig config;
        IHomePage homePage;
        INewCostumerPage newCostumerPage;
        public const string PAGE = "NewCustomerPage$";

        #endregion

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
        [DataSource(EXCEL_PROPERTIES, EXCEL_SHEET_LOCATION, PAGE, DataAccessMethod.Sequential)]
        public void VerifyCustomerNameByEnteringNumbers()
        {
            extent.CreateTest(TestContext.TestName);
            string ActualMessage = newCostumerPage.EnterInvalidCharacterInCustomerName(TestContext.DataRow["Data"].ToString());
            Assert.AreEqual(ActualMessage, TestContext.DataRow["ExpectedMessage"].ToString());
        }

        [TestMethod]
        [DataSource(EXCEL_PROPERTIES, EXCEL_SHEET_LOCATION, PAGE, DataAccessMethod.Sequential)]
        public void VerifyCustomerNameMaxCharactersLength()
        {
            extent.CreateTest(TestContext.TestName);
            string ActualMessage = newCostumerPage.EnterMaximumCharactersInCustomerName(TestContext.DataRow["MaxCharacter"].ToString());
            Assert.AreEqual(ActualMessage, TestContext.DataRow["Length"].ToString());
        }

        [TestMethod]
        [DataSource(EXCEL_PROPERTIES, EXCEL_SHEET_LOCATION, PAGE, DataAccessMethod.Sequential)]
        public void VerifyCustomerNameWithoutEnteringValue()
        {
            extent.CreateTest(TestContext.TestName);
            string ActualMessage = newCostumerPage.CustomerNameBlankVerify();
            Assert.AreEqual(ActualMessage, TestContext.DataRow["BlankMessage"].ToString());
        }

        [TestCleanup]
        public void TearDown()
        {
            SetUpResults(TestContext.CurrentTestOutcome.ToString());
            Page.QuitSession();
        }
    }
}
