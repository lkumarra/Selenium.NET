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
    public class EditCustomerTest : TestClassContext
    {
        ILoginPage loginPage;
        IConfig config;
        IHomePage homePage;
        IEditCostumerPage editCostumerPage;
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"C:\Users\Lavendra rajput\source\repos\SeleniumPOM\SeleniumPOM\TestData\Guru99Bank.csv", "Guru99Bank#csv", DataAccessMethod.Sequential)]
        public void VerifyCustomerIDEnteringInvalidCharacters()
        {
            string Message = editCostumerPage.CustomerIDInvaildCharactersAndMessageText(TestContext.DataRow["Data"].ToString());
            Assert.AreEqual(Message, TestContext.DataRow["Expected Message"].ToString());
        }

        [TestCleanup]
        public void TearDown()
        {
            Page.QuitSession();
        }

    }
}