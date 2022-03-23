using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;


namespace SeleniumTestProject.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver) => _driver = driver;

        IWebElement txtUserName => _driver.FindElement(By.Name("user-name"));
        IWebElement txtPassword => _driver.FindElement(By.Name("password"));
        IWebElement btnLogin => _driver.FindElement(By.Name("login-button"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
