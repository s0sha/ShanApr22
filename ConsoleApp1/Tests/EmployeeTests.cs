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
    //[Parallelizable]
    internal class EmployeeTests:CommonDriver
    {

       String Name = "Employee Employee";

        EmployeePage EmPage = new EmployeePage();
        CreateEmpRec EmCreatePage = new CreateEmpRec();
        
        [Test,Order(1)]
        public void CreateRecord() 
        {

            EmPage.OpenPage(driver);

           
            EmCreatePage.CreateNewEmpRecord(driver,Name);
        }

    }
}
