using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineElectronicShopTest.Pages
{
    public class CartPage
    {
        private IWebDriver driver;

        public CartPage(IWebDriver driver) {
            this.driver = driver;
        }

        private IWebElement cartPageLink => driver.FindElement(By.LinkText("Cart"));
        private IWebElement cartTable => driver.FindElement(By.Id("tbodyid"));
        public void goToCartPage()
        {
            cartPageLink.Click();
        }

        public bool IsProductInCart(string productName)
        {
               return cartTable.Text.Contains(productName);
        }
    }
}
