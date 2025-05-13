using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OnlineElectronicShopTest.Pages;
using OnlineElectronicShopTest.Utilities;
using OpenQA.Selenium;

namespace OnlineElectronicShopTest.Tests
{
    [TestFixture]
    public class LoginTest: TestBase
    {
        private LoginPage loginPage;
        private By welcomeText => By.Id("nameofuser");

        [SetUp]
        public void Setup()
        {
            this.loginPage = new LoginPage(driver);
            
        }

        [Test]
        public void TestNavigatesToHomePageSuccessfully()
        {
            this.loginPage.NavigateToLoginPage();
        }
        [Test]
        public void TestSuccessfulLogin()
        {
            this.loginPage.NavigateToLoginPage();
            this.loginPage.LoginToApplication("pvrano", "1234567");

             
            IWebElement welcomeTxt = WaitHelpers.WaitForElementVisible(driver, welcomeText);
            string welcometextActual = welcomeTxt.Text;
            Console.WriteLine(welcometextActual);
            string welcomeExpectedText = "Welcome pvrano";

            Assert.That(welcometextActual, Is.EqualTo(welcomeExpectedText), "The text is not as expected.");
        }
    }
}
