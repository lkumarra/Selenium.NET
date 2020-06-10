﻿using System;
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
        [DataSource("System.Data.Odbc", @"Dsn = Excel Files;dbq=C:\Users\Lavendra rajput\source\repos\SeleniumPOM\SeleniumPOM\TestData\Guru99Bank.xlsx;", "NewCustomerPage$", DataAccessMethod.Sequential)]
        public void VerifyCustomerNameByEnteringNumbers()
        {
            string ExpectedMessage = newCostumerPage.EnterInvalidCharacterInCustomerName(TestContext.DataRow["Data"].ToString());
            Assert.AreEqual(ExpectedMessage, TestContext.DataRow["ExpectedMessage"].ToString());
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", @"Dsn = Excel Files;dbq=C:\Users\Lavendra rajput\source\repos\SeleniumPOM\SeleniumPOM\TestData\Guru99Bank.xlsx;", "NewCustomerPage$", DataAccessMethod.Sequential)]
        public void VerifyCustomerNameMaxCharactersLength()
        {
            string ExpectedMessage = newCostumerPage.EnterMaximumCharactersInCustomerName(TestContext.DataRow["MaxCharacter"].ToString());
            Assert.AreEqual(ExpectedMessage, TestContext.DataRow["Length"].ToString());
        }

        [TestMethod]
        [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=C:\Users\Lavendra rajput\source\repos\SeleniumPOM\SeleniumPOM\TestData\Guru99Bank.xlsx;", "NewCustomerPage$", DataAccessMethod.Sequential)]
        public void VerifyCustomerNameWithoutEnteringValue()
        {
            string ExpectedMessage = newCostumerPage.CustomerNameBlankVerify();
            Assert.AreEqual(ExpectedMessage, TestContext.DataRow["BlankMessage"].ToString());
        }

        [TestCleanup]
        public void TearDown()
        {
            Page.QuitSession();
        }
    }
}