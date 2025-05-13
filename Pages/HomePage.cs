using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineElectronicShopTest.Utilities;
using OpenQA.Selenium;

namespace OnlineElectronicShopTest.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By FirstProductLink => By.LinkText("Nokia lumia 1520");
        

        public void ClickProduct()
        {
            IWebElement productLink = WaitHelpers.WaitForElementClickable(driver, FirstProductLink);

            productLink.Click();
        }

    }
}
