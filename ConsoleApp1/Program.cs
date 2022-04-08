using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            IWebElement usernameText = driver.FindElement(By.Id("UserName"));

            usernameText.SendKeys("hari");

            IWebElement passwordText = driver.FindElement(By.Id("Password"));
            passwordText.SendKeys("123123");

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {

                Console.WriteLine("Test Passed");
            }
            else { Console.WriteLine("Test Failed"); }
                
                    
                    
        }
    }
}
