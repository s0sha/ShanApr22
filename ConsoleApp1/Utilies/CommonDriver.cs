using ConsoleApp1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utilies
{
    internal class CommonDriver
    {

        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginFunction()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            HomePage SiteLogin = new HomePage();
            SiteLogin.LoginToSite(driver);

           

        }


        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
