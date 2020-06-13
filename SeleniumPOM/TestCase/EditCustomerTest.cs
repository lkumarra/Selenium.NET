using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Config;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Actions;
using SeleniumPOM.BasePage;
using SeleniumPOM.TestContextClass;

namespace SeleniumPOM.TestCase
{
    [TestClass]
    public class EditCustomerTest : TestClassContext
    {
        #region Fields 

        ILoginPage loginPage;
        IConfig config;
        IHomePage homePage;
        IEditCostumerPage editCostumerPage;
        public const string PAGE = "EditCustomerPage$";

        #endregion

        [TestInitialize]
        public void SetUp()
        {
            Page.Initialization();
            loginPage = new LoginPage();
            config = new AppConfigReader();
            homePage = loginPage.Login(config.GetUserName(), config.GetPassword());
            editCostumerPage = homePage.ClickOnEditCustomerPage();
        }

        [TestMethod]
        [DataSource(EXCEL_PROPERTIES, EXCEL_SHEET_LOCATION, PAGE, DataAccessMethod.Sequential)]
        public void VerifyCustomerIDEnteringInvalidCharacters()
        {
            extent.CreateTest(TestContext.TestName);
            string ActualMessage = editCostumerPage.CustomerIDInvaildCharactersAndMessageText(TestContext.DataRow["Data"].ToString());
            Assert.AreEqual(ActualMessage, TestContext.DataRow["ExpectedMessage"].ToString());
        }

        [TestCleanup]
        public void TearDown()
        {
            SetUpResults(TestContext.CurrentTestOutcome.ToString());
            Page.QuitSession();
        }

    }
}
