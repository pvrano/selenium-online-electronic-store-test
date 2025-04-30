using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OnlineElectronicShopTest.Drivers
{
    public static class DriverFactory
    {
        [ThreadStatic]
        private static IWebDriver driver;
        public static IWebDriver GetDriver()
        {
            if(driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void QuitDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
