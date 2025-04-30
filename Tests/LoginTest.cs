using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OnlineElectronicShopTest.Pages;
using OpenQA.Selenium;

namespace OnlineElectronicShopTest.Tests
{
    [TestFixture]
    public class LoginTest: TestBase
    {
        private LoginPage loginPage;
        

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

             string welcomeTextActual = driver.FindElement(By.Id("nameofuser")).Text;
             Console.WriteLine(welcomeTextActual);
            string welcomeExpectedText = "Welcome pvrano";

            Assert.AreEqual(welcomeExpectedText, welcomeTextActual, "The text is not as expected.");
        }
    }
}
