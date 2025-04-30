using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OnlineElectronicShopTest.Drivers;


namespace OnlineElectronicShopTest.Tests
{
    public class TestBase
    {
        protected IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = DriverFactory.GetDriver();
        }

        [TearDown]
        public void TearDown()
        {
            DriverFactory.QuitDriver();
        }
    }
}
