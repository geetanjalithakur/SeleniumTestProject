using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTestProject.Drivers;
using SeleniumTestProject.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumTestProject.Steps
{
    [Binding]
    public class LoginSteps
    {
        IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;
        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Url = "https://www.saucedemo.com/";
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            LoginPage page = new LoginPage(driver);
            page.EnterUserNameAndPassword((String)data.UserName, (String)data.Password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            Thread.Sleep(1000);
            LoginPage page = new LoginPage(driver);
            page.ClickLogin();
            Thread.Sleep(2000);
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            var element = driver.FindElement(By.XPath("//*[@id='item_4_title_link']/div"));
            Assert.AreEqual("Sauce Labs Backpack", element.Text);
        }
    }
}
