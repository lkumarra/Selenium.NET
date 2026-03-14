using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReportingLibrary;
using SeleniumPOM.Utilities;
using System;

namespace SeleniumPOM.TestContextClass
{
    [TestClass]
    public class TestClassContext
    {
        public TestContext TestContext { get; set; }

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
                if (extent == null || extent.test == null)
                    return;

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
            catch (Exception)
            {
                // Swallow reporting errors to avoid masking test failures
            }
        }

        [AssemblyCleanup]
        public static void CloseReporter()
        {
            if (extent != null)
            {
                extent.Close();
            }
            //MailUtil.SendAttachedReport();
        }
    }
}
