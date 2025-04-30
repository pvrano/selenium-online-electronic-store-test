using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        
        private IWebElement LoginNavButton => driver.FindElement(By.Id("login2"));
        private IWebElement UsernameInput => driver.FindElement(By.Id("loginusername"));

        internal void NavigateToLoginPage()
        {
            this.driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
        }

        private IWebElement PasswordInput => driver.FindElement(By.Id("loginpassword"));
        
        private IWebElement LoginSubmitButton => driver.FindElement(By.XPath("//button[contains(text(),'Log in')]"));
        

        public void OpenLoginModel()
        {
            LoginNavButton.Click();
        }

        public void EnterCredentials(string username, string password)
        {
            UsernameInput.SendKeys(username);
            PasswordInput.SendKeys(password);
        }

        public void SubmitLogin()
        {
            if (LoginSubmitButton.Displayed)
            {
                LoginSubmitButton.Click();
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
