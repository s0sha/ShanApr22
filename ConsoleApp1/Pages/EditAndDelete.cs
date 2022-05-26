using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp1.Utilies;


namespace ConsoleApp1.Pages
{
    internal class EditAndDelete
    {

        public void EditLastRecord(IWebDriver driver,string pCode)
        {
            Wait.WaitForClickableWE(driver,"By.XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 30);

            IWebElement gotolastpageTab = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageTab.Click();
            
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
           

            if (lastRecord.Text == pCode)
            {
                IWebElement EditLastRec = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                EditLastRec.Click();

                IWebElement EditPrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));

                EditPrice.Click();
                EditPrice.Clear();
                
                EditPrice.SendKeys("100.00");
                //EditPrice.Click();

                IWebElement SaveEdit = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
                SaveEdit.Click();


            }


            driver.Navigate().Refresh();
            

            //wait for visible
            Wait.WaitForVisibleWE(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 30);
            
            IWebElement gotolpageTab = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolpageTab.Click();

            IWebElement lastRecordEdited = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            
            if (lastRecordEdited.Text == pCode)
            {
                IWebElement lastRecPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
                if (lastRecPrice.Text == "$100.00")
                {
                    Assert.Pass("Record Price Edit was Successful.");


                }
                else {
                    Assert.Pass("Price Edit was not Successful.");
                }
            }
            else
            {
                Assert.Fail("Record Edit Not Found. Edit Record was not Successful.");
            }


        }



        public void DeleteLastRecord(IWebDriver driver,string pCode)
        {
            Wait.WaitForClickableWE(driver,"By.XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 30);

            IWebElement gotolastpageTab = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageTab.Click();

            
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastRecord.Text == pCode)
            {

                IWebElement deleteTMRec = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteTMRec.Click();

                Wait.WaitForVisibleWE(driver,"By.XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 30);

                driver.SwitchTo().Alert().Accept();
              
                

            }


            driver.Navigate().Refresh();

            //wait for visible
            Wait.WaitForVisibleWE(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 1000);

           

            IWebElement gotolpageTab = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolpageTab.Click();

            IWebElement lastRecordDeleted = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(lastRecordDeleted.Text!=pCode,"Record Not Deleted");

            if (lastRecordDeleted.Text != pCode)
            {
                Assert.Pass("Record Delete was Successful.");
            }
            else 
            {
                Assert.Fail("Record Delete was not Successful ");
            }


        }

    }
}
