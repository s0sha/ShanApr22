using System;
using TechTalk.SpecFlow;
using ConsoleApp1.Utilies;
using ConsoleApp1.Tests;

namespace ConsoleApp1.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        CommonDriver cD = new CommonDriver();
        TMTests tmTest = new TMTests();
        EmployeeTests empTest = new EmployeeTests();


        [Given(@"I have logged into turnup portal successfully\.")]
        public void GivenIHaveLoggedIntoTurnupPortalSuccessfully_()
        {
                        cD.LoginFunction();
            //throw new PendingStepException();
        }

        [When(@"I navigate to Time and Material page\.")]
        public void WhenINavigateToTimeAndMaterialPage_()
        {
            empTest.CreateRecord();
           // tmTest.CreateRecord();

           
            
             throw new PendingStepException();
        }

        [When(@"I create a new record\.")]
        public void WhenICreateANewRecord_()
        {
           // tmTest.EandDeRecord();
           // tmTest.DeleteRecord();

            // throw new PendingStepException();
        }

        [Then(@"The record should be created successfully\.")]
        public void ThenTheRecordShouldBeCreatedSuccessfully_()
        {

            cD.CloseTestRun();    
            throw new PendingStepException();
        
        }
    }
}
