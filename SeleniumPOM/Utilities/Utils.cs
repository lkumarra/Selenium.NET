using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumPOM.Interfaces;
using SeleniumPOM.BasePage;
using System;

namespace SeleniumPOM.Utilities
{
    class Utils : Page, IUtil
    {
        private static void ElementToBeClickableWait(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        private static void ElementToBeVisibleWait(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public void ClickOnElement(IWebElement element)
        {
            ElementToBeClickableWait(element);
            element.Click();
        }

        public void EnterTextIntoElement(IWebElement element, string text)
        {
            ElementToBeClickableWait(element);
            element.SendKeys(text);
        }

        public void EnterTextIntoElementWithClear(IWebElement element, string text)
        {
            ElementToBeClickableWait(element);
            element.Clear();
            element.SendKeys(text);
        }

        public string GetElementText(IWebElement element)
        {
            ElementToBeVisibleWait(element);
            return element.Text;
        }

        public string GetElementAttribute(IWebElement element, string attribute)
        {
            ElementToBeVisibleWait(element);
            return element.GetAttribute(attribute);
        }

        public string GetAlertTextAndAccept()
        {
            IAlert Alert = driver.SwitchTo().Alert();
            string AlertText = Alert.Text;
            Alert.Accept();
            return AlertText;
        }

        public void SelectByVisibleText(IWebElement Elemenet, string Text)
        {
            SelectElement select = new SelectElement(Elemenet);
            select.SelectByText(Text);
        }

        public void JSExecutor()
        {
            IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;
            javaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView();", driver.FindElement(By.LinkText("Log out")));
        }

        public void JSExecutorClick(IWebElement Element)
        {
            IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;
            javaScriptExecutor.ExecuteScript("arguments[0].click();", Element);
        }
    }
}
