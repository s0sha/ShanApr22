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
        public static void WaitForWebElement(IWebDriver driver,string locator,string locatorValue,int sec) 
        {
            var waitElement = new WebDriverWait(driver, new TimeSpan(0, 0, sec));
            if (locator == "XPath")
            {
                waitElement.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            else if (locator == "Id") 
            {
                waitElement.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }

        }
    }
}
