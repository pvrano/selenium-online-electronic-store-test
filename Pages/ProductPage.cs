using OnlineElectronicShopTest.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineElectronicShopTest.Pages
{
    public class ProductPage
    {
        private IWebDriver driver;

        public ProductPage(IWebDriver driver) {
            this.driver = driver;
        }

        private By AddtoCartBtn => By.LinkText("Add to cart");
        
        public void ClickAddtoCart()
        {
            IWebElement addToCartBtn = WaitHelpers.WaitForElementClickable(driver, AddtoCartBtn);
            addToCartBtn.Click();
        }

        public void AcceptOkAlert()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
