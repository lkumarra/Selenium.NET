using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Config;
using SeleniumPOM.Interfaces;
using SeleniumPOM.Pages.Actions;
using SeleniumPOM.BasePage;
using SeleniumPOM.TestContextClass;

namespace SeleniumPOM
{
    [TestClass]
    public class HomeTest : TestClassContext
    {
        #region Fields 

        IHomePage homerPage;
        ILoginPage loginPage;
        IConfig config;

        #endregion

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
            extent.CreateTest(TestContext.TestName);
            string welcomeMessage = homerPage.GetWelcomeMessage();
            Assert.IsNotNull(welcomeMessage);
        }

        [TestMethod]
        public void VerifyMangerID()
        {
            extent.CreateTest(TestContext.TestName);
            string managerId = homerPage.GetManagerID();
            Assert.IsNotNull(managerId);
        }

        [TestCleanup]
        public void TearDown()
        {
            SetUpResults(TestContext.CurrentTestOutcome.ToString());
            Page.QuitSession();
        }
    }
}
