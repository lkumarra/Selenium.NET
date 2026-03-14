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
        public void VerifyCustomerIDEnteringInvalidCharacters()
        {
            extent.CreateTest(TestContext.TestName);
            string ActualMessage = editCostumerPage.CustomerIDInvaildCharactersAndMessageText("abc");
            Assert.IsNotNull(ActualMessage);
        }

        [TestCleanup]
        public void TearDown()
        {
            SetUpResults(TestContext.CurrentTestOutcome.ToString());
            Page.QuitSession();
        }
    }
}
