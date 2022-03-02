using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowNetCoreDemo.Pages
{
   public class LoginPage
    {
        public IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver webDriver) 
        {
            WebDriver = webDriver;
        }

        public IWebElement lnkLogin => WebDriver.FindElement(By.LinkText("Login"));

        public IWebElement txtUserName => WebDriver.FindElement(By.Name("UserName"));

        public IWebElement txtPassword => WebDriver.FindElement(By.Name("Password"));
        public IWebElement btnLogin => WebDriver.FindElement(By.CssSelector(".btn-default"));

        public IWebElement lnkEmployeeDetails => WebDriver.FindElement(By.LinkText("Employee Details"));


        public void ClickLogin() => lnkLogin.Click();

        public void Login(string userName , string password) 
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLoginButton() => btnLogin.Submit();

        public bool IsEmployeeDetailsExists() => lnkEmployeeDetails.Displayed;

    }
}
