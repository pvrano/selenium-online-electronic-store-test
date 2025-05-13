
using NUnit.Framework;
using OpenQA.Selenium;
using OnlineElectronicShopTest.Drivers;
using AventStack.ExtentReports;
using static System.Web.Razor.Parser.SyntaxConstants;
using AventStack.ExtentReports.Reporter;
using OnlineElectronicShopTest.Reports;
using WebShopAutomationFramework.Reports;


namespace OnlineElectronicShopTest.Tests
{
    public class TestBase
    {
        protected IWebDriver driver;
        protected ExtentTest test;



        [SetUp]
        public void SetUp()
        {
            driver = DriverFactory.GetDriver();
            string testName = TestContext.CurrentContext.Test.Name;
            test = ExtentReportManager.CreateTest(testName);
            if (test == null)
            {
                throw new Exception("ExtentTest is null in SetUp — report manager failure.");
            }

            test.Info("Test setup complete");
            test.Info("Starting test: " + testName);

        }

        [TearDown]
        public void TearDown()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var errorMessage = TestContext.CurrentContext.Result.Message;
            var outcome = TestContext.CurrentContext.Result.Outcome.Status;


            if (test == null)
            {
                Console.WriteLine("ExtentTest is null in TearDown — check SetUp or CreateTest logic.");
            }
            else
            {
                if (outcome == NUnit.Framework.Interfaces.TestStatus.Passed)
                {
                    test.Pass("Test Passed");
                }
                else if (outcome == NUnit.Framework.Interfaces.TestStatus.Failed)
                {
                    test.Fail("Test Failed: " + errorMessage);



                    DriverFactory.QuitDriver();
                    ExtentReportManager.FlushReport();

                }
            }
        }
    }
}