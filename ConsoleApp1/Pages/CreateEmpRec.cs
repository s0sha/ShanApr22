using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp1.Utilies;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages
{
    internal class CreateEmpRec
    {

        public void CreateNewEmpRecord(IWebDriver driver, string pCode)
        {
            try
            {

                IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
                CreateNew.Click();

                IWebElement CreateName = driver.FindElement(By.XPath("//*[@id='Name']"));
                CreateName.SendKeys(pCode);

                IWebElement CreateUserName = driver.FindElement(By.XPath("//*[@id='Username']"));
                CreateUserName.SendKeys("Emp");


                IWebElement CreateContact = driver.FindElement(By.XPath("//*[@id='ContactDisplay']"));
                CreateContact.SendKeys("NameName");


                IWebElement CreatePassword = driver.FindElement(By.XPath("//*[@id='Password']"));
                CreatePassword.SendKeys("EmployeeName1$");

                IWebElement CreateRetype = driver.FindElement(By.XPath("//*[@id='RetypePassword']"));
                CreateRetype.SendKeys("EmployeeName1$");

                IWebElement CreateIsAdmin = driver.FindElement(By.XPath("//*[@id='IsAdmin']"));
                CreateIsAdmin.Click();

                IWebElement CreateVehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
                CreateVehicle.SendKeys("Mini");


                IWebElement CreateGroup = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
                CreateGroup.SendKeys("Emp"); CreateGroup.SendKeys(Keys.Return);

                IWebElement CreateSave = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
                CreateSave.Click();

            }
            catch (Exception ex)
            { 
                Assert.Fail("Employee Creation Exception  "+ ex.Message);
            }
        }

    }
}
