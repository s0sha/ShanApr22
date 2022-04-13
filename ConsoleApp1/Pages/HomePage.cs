using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1.Pages
{
    internal class HomePage
    {

        public void LoginToSite(IWebDriver driver)
        {
            
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/login?ReturnUrl=%2f");
           
            
            try
            {

                IWebElement usernameText = driver.FindElement(By.Id("UserName"));
                usernameText.SendKeys("hari");

                IWebElement passwordText = driver.FindElement(By.Id("Password"));
                passwordText.SendKeys("123123");

                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();

            }
            catch (Exception ex) 
            { 
            
                Assert.Fail("Login Page did not Launch ", ex.Message);
                throw;
            
            }
            
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

           
            
        }

    }
}
