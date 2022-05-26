using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages
{
    internal class EmployeePage
    {

        public void OpenPage(IWebDriver driver) 
        {

            IWebElement OpenAdministrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            OpenAdministrationTab.Click();

            IWebElement OpenEmployeePage = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            OpenEmployeePage.Click();





        }

    }
}
