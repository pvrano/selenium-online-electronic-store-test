
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

namespace WebShopAutomationFramework.Reports
{
    public static class ExtentReportManager
    {
        private static ExtentReports extent;
        private static ExtentHtmlReporter htmlReporter;
        public static ExtentReports GetReporter()
        {
            if (extent == null)
            {
                string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "TestReport.html");
                htmlReporter = new ExtentHtmlReporter(reportPath);

                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
            }
            return extent;
        }

        public static ExtentTest CreateTest(string testName)
        {
            var reporter = GetReporter();
            return reporter.CreateTest(testName); // 🔥 always return a non-null test object
        }

        public static void FlushReport()
        {
            if (extent != null)
            {
                extent.Flush();
            }
        }
    }
}