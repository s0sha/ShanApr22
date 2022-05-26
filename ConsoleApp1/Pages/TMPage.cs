using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ConsoleApp1.Utilies;
using NUnit.Framework;

namespace ConsoleApp1.Pages
{
    internal class TMPage
    {
        public void GoToTMPage(IWebDriver driver) 
        {

            OpenQA.Selenium.IWebElement administrationDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropDown.Click();

            Wait.WaitForClickableWE(driver,"XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();

        

        }

    }
}
