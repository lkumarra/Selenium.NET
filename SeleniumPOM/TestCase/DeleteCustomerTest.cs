using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Config;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Actions;
using SeleniumPOM.BasePage;
using SeleniumPOM.TestContextClass;

namespace SeleniumPOM.TestCase
{
    [TestClass]
    public class DeleteCustomerTest : TestClassContext
    {
        #region Fields

        ILoginPage loginPage;
        IConfig config;
        IHomePage homePage;
        IDeleteCustomerPage deleteCustomerPage;

        #endregion

        [TestInitialize]
        public void SetUp()
        {
            Page.Initialization();
            config = new AppConfigReader();
            loginPage = new LoginPage();
            homePage = loginPage.Login(config.GetUserName(), config.GetPassword());
            deleteCustomerPage = homePage.ClickOnDeleteCustomerPage();
        }

        [TestMethod]
        public void VerifyCustomerIdMessage()
        {
            extent.CreateTest(TestContext.TestName);
            string ActualMessage = deleteCustomerPage.EnterInvalidCharacterAndGetMessage("abc");
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
