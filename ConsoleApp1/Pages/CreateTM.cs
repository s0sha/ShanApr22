using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp1.Utilies;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp1.Pages
{
    internal class CreateTM
    {


        public void CreateNewRecord(IWebDriver driver,string pCode)
        {


            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            IWebElement typeCodeDropDown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropDown.Click();
            
            //Wait

            IWebElement materialOption = driver.FindElement(By.Id("TypeCode_option_selected"));
            materialOption.SendKeys("Material");



            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys(pCode);

            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys(pCode);

            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
            priceTextBox.SendKeys("10");


            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            
            driver.Navigate().Refresh();

            Wait.WaitForVisibleWE(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 30);
            
            IWebElement gotolastpageTab = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageTab.Click();

            
            Wait.WaitForVisibleWE(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 30);

            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement lastRecordType = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            IWebElement lastRecordDesc = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement lastRecordPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            


            Assert.That(lastRecord.Text == pCode, "Record Not Created");
            Assert.That(lastRecordType.Text == "M", "Record Type does not Match");
            Assert.That(lastRecordDesc.Text == pCode, "Record Description does not Match");
            Assert.That(lastRecordPrice.Text == "$10.00", "Record Price does not Match");

            
        }



    }
}
