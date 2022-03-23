using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumTestProject.Drivers
{
    public class SeleniumDriver
    {
        private IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

        public SeleniumDriver(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        
        public IWebDriver Setup()
        {
            var chromeOption = new ChromeOptions();
            driver = new ChromeDriver(chromeOption);
            _scenarioContext.Set(driver, "webDriver");
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
