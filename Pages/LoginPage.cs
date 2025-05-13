using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineElectronicShopTest.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
namespace OnlineElectronicShopTest.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        
        private By LoginNavButton => By.Id("login2");
        private By UsernameInput => By.Id("loginusername");

        internal void NavigateToLoginPage()
        {
            this.driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
        }

        private By PasswordInput => By.Id("loginpassword");
        
        private By LoginSubmitButton => By.XPath("//button[contains(text(),'Log in')]");
        

        public void OpenLoginModel()
        {
            WaitHelpers.WaitForElementClickable(driver,LoginNavButton).Click();
        }

        public void EnterCredentials(string username, string password)
        {
            WaitHelpers.WaitForElementVisible(driver, UsernameInput).SendKeys(username);
            WaitHelpers.WaitForElementVisible(driver, PasswordInput).SendKeys(password);
        }

        public void SubmitLogin()
        {
            if (WaitHelpers.WaitForElementVisible(driver, LoginSubmitButton).Displayed)
            {
                WaitHelpers.WaitForElementVisible(driver, LoginSubmitButton).Click();
            }
            else
            {
                Console.WriteLine("Login button is not displayed.");
                // Handle the situation (e.g., wait for it to be displayed, throw an exception, etc.)
            }

            
        }

        public void LoginToApplication(string username,string password)
        {
            OpenLoginModel();
            Thread.Sleep(1000);
            EnterCredentials(username, password);
            //Thread.Sleep(3000);
            SubmitLogin();
        }
    }
}
