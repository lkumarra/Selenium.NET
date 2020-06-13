using System;
using System.IO;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.TestContextClass;
using SeleniumPOM.Utilities;

namespace SeleniumPOM.TestCase
{
    [TestClass]
    public class UnitTest1 : TestClassContext
    {
        public const string PAGE = "HomePage$";
        [TestMethod]
        [DataSource(EXCEL_PROPERTIES, EXCEL_SHEET_LOCATION, PAGE, DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            MailUtil.SendAttachedReport();
        }
    }
}
