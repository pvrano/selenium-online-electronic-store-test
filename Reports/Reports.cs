using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.IO;

namespace OnlineElectronicShopTest.Reports
{
    public static class Reports
    {
        private static ExtentReports extent;
        private static ExtentTest test;

        public static ExtentReports GetReporter()
        {
            if (extent == null)
            {
                var htmlReporter = new ExtentHtmlReporter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "TestReport.html"));
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
            }
            return extent;
        }

        public static ExtentTest CreateTest(string testName)
        {
            test = GetReporter().CreateTest(testName);
            return test;
        }

        public static void FlushReport()
        {
            extent.Flush();
        }

        public static ExtentTest GetTest() => test;
    }

}

