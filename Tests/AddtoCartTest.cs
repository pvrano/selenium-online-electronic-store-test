using OnlineElectronicShopTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineElectronicShopTest.Tests
{
    [TestFixture]
    public class AddtoCartTest : TestBase


    {
        
        [Test]
        public void addProductToCartTest()
        {
            test.Info("Navigating to Demoblaze");
            var loginPage = new LoginPage(driver);
            loginPage.NavigateToLoginPage();

            var home = new HomePage(driver);
            test.Info("clicking on product");
            home.ClickProduct();




            var product = new ProductPage(driver);
            product.ClickAddtoCart();
            test.Info("Clicked Add to Cart");

            product.AcceptOkAlert();
            test.Info("Accepted alert");

            var cart = new CartPage(driver);
            cart.goToCartPage();
            test.Info("Opened cart page");
            Assert.IsTrue(cart.IsProductInCart("Nokia lumia 1520"), "Product not in cart");
            test.Pass("Product successfully added to cart and verified in cart page");


        }
    }
}
