using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlow_BDD
{ 

    [Binding]
    public sealed class Hooks
    {
        public IWebDriver Driver;

        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();

            _scenarioContext["ChromeDriver"] = Driver; //keeping at common place

            _scenarioContext["Username"] = "admin";
            _scenarioContext["Password"] = "user";

        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
