using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using ConsoleApp1.Pages;
using ConsoleApp1.Utilies;
using System;
using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    [TestFixture]
    internal class Program:CommonDriver
    {
            

        [SetUp]
        public void LoginFunction()
        {
            driver =new ChromeDriver();
            driver.Manage().Window.Maximize();

            HomePage SiteLogin = new HomePage();
            SiteLogin.LoginToSite(driver);

            TMPage TMPageObj = new TMPage();
            TMPageObj.GoToTMPage(driver);


        }

        
        [Test]
        public void CreateRecord() 
        {

            CreateTM NewTMRecord = new CreateTM();
            NewTMRecord.CreateNewRecord(driver);

        }

        

        [TearDown]
        public void CloseTestRun() { }

    }
}
