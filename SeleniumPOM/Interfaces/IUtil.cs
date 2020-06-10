﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.Interfaces
{
    interface IUtil
    {
        /// <summary>
        /// Perform click operation on the element.
        /// </summary>
        /// <param name="element">Webelement to perforn click operation</param>
        void ClickOnElement(IWebElement element);

        /// <summary>
        /// Enter text into webelement.
        /// </summary>
        /// <param name="element">
        /// Webelement to enter text
        /// </param>
        /// <param name="text">
        /// Text to enter in element
        /// </param>
        void EnterTextIntoElement(IWebElement element, string text);

        /// <summary>
        /// Enter text into element after clear operation.
        /// </summary>
        /// <param name="element">Webelement to enter text</param>
        /// <param name="text">Text to enter in element</param>
        void EnterTextIntoElementWithClear(IWebElement element, string text);

        /// <summary>
        /// Get the text of the Webelement.
        /// </summary>
        /// <param name="element">Webelement to get text</param>
        /// <returns>Text of the Webelement</returns>
        string GetElementText(IWebElement element);

        /// <summary>
        /// Get the attribute value in the webelement.
        /// </summary>
        /// <param name="element">Webelement to get attribute value</param>
        /// <param name="attribute">Name of attribute to get value</param>
        /// <returns>Attribute value </returns>
        string GetElementAttribute(IWebElement element, string attribute);

        /// <summary>
        /// Get alert text and accept alert.
        /// </summary>
        /// <returns>Text of the alert</returns>
        string GetAlertTextAndAccept();
       
    }
}
