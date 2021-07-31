﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using TechTalk.SpecFlow;

namespace SpecFlow_BDD.StepDefinition
{
    [Binding]
    public class GmailLogin
    {
        IWebDriver browser;
        private readonly ScenarioContext scenarioContext;

        public GmailLogin(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }
        [Given(@"Open Gmail Login Page")]
        public void GivenOpenGmailLoginPage()
        {
            browser = (IWebDriver)scenarioContext["ChromeDriver"];
            browser.Url = "http://www.gmail.com";
            browser.TakeScreenshot("/Users/madhurimaatla/Projects/screenshot");
        }

        [When(@"User Enters Valid Credential")]
        public void WhenUserEntersCredential()
        {

        }

        [Then("Successful Login into account")]
        public void ThenSuccessfulLogin()
        {

        }
    }
}

