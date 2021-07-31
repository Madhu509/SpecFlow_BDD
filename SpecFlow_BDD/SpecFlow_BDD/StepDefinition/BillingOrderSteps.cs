using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow_BDD
{
    [Binding]
    public class BillingOrderSteps
    {
        IWebDriver browser;

        private readonly ScenarioContext scenarioContext;

        public BillingOrderSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"Open Billing Order page")]
        public void GivenOpenBillingOrderPage()
        {
            browser = (IWebDriver)scenarioContext["ChromeDriver"];
            string Username = (String)scenarioContext["Username"];
            string password = (String)scenarioContext["Password"];

            browser.Url = "http://www.google.com";


        }

        [When(@"Enter User Details")]
        public void WhenEnterUserDetails()
        {

        }

        [When(@"Submit User Details")]
        public void WhenSubmitUserDetails()
        {

        }

        [Then(@"Form Should be submitted successfully")]
        public void ThenFormShouldBeSubmittedSuccessfully()
        {

        }
    }
}

