using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Interfaces
{
    interface IUtil
    {
        void ClickOnElement(IWebElement element);

        void EnterTextIntoElement(IWebElement element, string text);

        void EnterTextIntoElementWithClear(IWebElement element, string text);

        string GetElementText(IWebElement element);

        string GetElementAttribute(IWebElement element, string attribute);

        string GetAlertTextAndAccept();
       
    }
}
