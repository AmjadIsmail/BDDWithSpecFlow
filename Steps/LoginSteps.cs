using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowNetCoreDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowNetCoreDemo.Steps
{
    [Binding]
    public sealed class LoginSteps
    {

        // Anti-context Injection Code -- 100% wrong
        LoginPage loginpage = null;

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            loginpage = new LoginPage(webDriver);

        }

        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            loginpage.ClickLogin();
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginpage.Login((string)data.UserName, (string)data.Password);

        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginpage.ClickLoginButton();

        }

        [Then(@"I should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            Assert.That(loginpage.IsEmployeeDetailsExists(), Is.True);
        }

    }
}
