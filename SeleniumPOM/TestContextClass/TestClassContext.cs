using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReportingLibrary;
using SeleniumPOM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM.TestContextClass
{
    [TestClass]
    public class TestClassContext
    {
        private TestContext _testContext;

        public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }

        public const string EXCEL_SHEET_LOCATION = "Dsn = Excel Files;dbq=../../TestData/Guru99Bank.xlsx;";
        public const string EXCEL_PROPERTIES = "System.Data.Odbc";

        public static ExtentReportsHelper extent;

        [AssemblyInitialize]
        public static void SetUpReporter(TestContext context)
        {
            extent = new ExtentReportsHelper();
        }

        public void SetUpResults(string Status)
        {
            try
            {
                switch (Status)
                {
                    case "Failed":
                        extent.SetTestStatusFail();
                        break;
                    case "Skipped":
                        extent.SetTestStatusSkipped();
                        break;
                    default:
                        extent.SetTestStatusPass();
                        break;
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        [AssemblyCleanup]
        public static void CloseReporter()
        {
            extent.Close();
            //MailUtil.SendAttachedReport();
        }
    }
}
