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
        public void VerifyCustomerNameByEnteringNumbers()
        {
            extent.CreateTest(TestContext.TestName);
            string ActualMessage = newCostumerPage.EnterInvalidCharacterInCustomerName("1234");
            Assert.IsNotNull(ActualMessage);
        }

        [TestMethod]
        public void VerifyCustomerNameWithoutEnteringValue()
        {
            extent.CreateTest(TestContext.TestName);
            string ActualMessage = newCostumerPage.CustomerNameBlankVerify();
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
