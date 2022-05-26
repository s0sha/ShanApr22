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
    internal class TMTests:CommonDriver
    {
        TMPage TMPageObj = new TMPage();
        EditAndDelete lastRec = new EditAndDelete();

        String Code= "TM001";
        
        [Test,Order(1)]
        public void CreateRecord() 
        {
            TMPageObj.GoToTMPage(driver);

            CreateTM NewTMRecord = new CreateTM();
            NewTMRecord.CreateNewRecord(driver,Code);

        }

        [Test,Order(2)]
        public void EandDeRecord() 
        {
                    
           
            lastRec.EditLastRecord(driver,Code);
            
        }

        [Test,Order(3)]
        public void DeleteRecord() 
        {
          
          
            lastRec.DeleteLastRecord(driver,Code);
        }


        


    }
}
