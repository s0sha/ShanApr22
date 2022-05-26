using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utilies
{
    internal static class Wait
    {
        public static void WaitForClickableWE(IWebDriver driver,string locator,string locatorValue,int sec) 
        {
            //var waitElement = new WebDriverWait(driver, new TimeSpan(0, 0, sec));
            var waitElement = new WebDriverWait(driver, new TimeSpan(sec));
           

            if (locator == "XPath")
            {
                waitElement.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            else if (locator == "Id") 
            {
                waitElement.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }

        }

        public static void WaitForVisibleWE(IWebDriver driver, string locator, string locatorValue, int sec) 
        {
            var waitElement = new WebDriverWait(driver, new TimeSpan(sec));
            if (locator == "XPath") 
            {
                waitElement.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }
            if (locator == "Id") 
            {
                waitElement.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }
        
        
        }
    }
}
