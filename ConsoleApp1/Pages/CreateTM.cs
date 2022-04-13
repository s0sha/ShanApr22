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


        public void CreateNewRecord(IWebDriver driver) 
        {
                

            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            IWebElement typeCodeDropDown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropDown.Click();
            Thread.Sleep(1000);

            //IWebElement materialOption = driver.FindElement(By.XPath("[@id='TypeCode_option_selected']"));
            //materialOption.Click();
            

            IWebElement materialOption = driver.FindElement(By.Id("TypeCode_option_selected"));
            materialOption.SendKeys("Material");


            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("Material1");

            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Material1");

            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
            priceTextBox.SendKeys("10");


           // IWebElement selectFileTab = driver.FindElement(By.Id("files"));
           // selectFileTab.SendKeys("C:/Users/61420/Desktop/290322.txt");


            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //Wait.WaitForWebElement(driver, "XPath", "[@id='tmsGrid']/div[4]/a[4]/span", 2);

            
            IWebElement gotolastpageTab = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageTab.Click();
            
            Thread.Sleep(2000);

            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            
            Assert.That(lastRecord.Text=="Material1","Record Not Created");

            if (lastRecord.Text == "Material1") {
                Assert.Pass("Record Created Successfully");
            }

            else { Assert.Fail("Record Not Found" ); }


            }

    }
}
