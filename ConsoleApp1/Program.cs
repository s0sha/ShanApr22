using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

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

                Console.WriteLine("Login Successful");
            }
            else { Console.WriteLine("Login Failed"); }

            IWebElement administrationDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropDown.Click();

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();

            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            IWebElement typeCodeDropDown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropDown.Click();


            //            IWebElement materialOption = driver.FindElement(By.XPath("[@id='TypeCode_option_selected']"));
            //materialOption.Click();
            
            IWebElement materialOption = driver.FindElement(By.Id("TypeCode_option_selected"));
            materialOption.SendKeys("Material");

            
            

            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("001");

            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Material1");

            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
            priceTextBox.SendKeys("10");


           // IWebElement selectFileTab = driver.FindElement(By.Id("files"));
           // selectFileTab.SendKeys("C:/Users/61420/Desktop/290322.txt");

           // Thread.Sleep(8000);


            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);

            IWebElement gotolastpageTab = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageTab.Click();
            Thread.Sleep(2000);

            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            
            if (lastRecord.Text == "001") { Console.WriteLine("Record Created "); }

            else { Console.WriteLine("Record Not Found" ); }

            








        }
    }
}
