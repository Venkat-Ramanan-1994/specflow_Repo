using MonoPriceWebBDD.pageFactory.HomePage;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MonoPriceWebBDD.stepDefinitions.Login
{
    [Binding]
    public sealed class LoginPageSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly string baseUrl = ScenarioContext.Current["baseUrl"].ToString();


        IWebDriver driver;
        LoginPage objLogin;
        MyAccountPage objMyAccount;

        public LoginPageSteps(IWebDriver Driver)
        {
            driver = Driver;
            objLogin = new LoginPage(driver);
            objMyAccount = new MyAccountPage(driver);

        }
        [Then(@"I Navigate to MyAccount Login Page")]
        public void ThenINavigateToMyAccountPage()
        {

            driver.Navigate().GoToUrl($"{baseUrl}/myaccount/myaccount");
            Console.WriteLine("Navigated to Login Page Successfully");
        }



        [When(@"I log in using Username as ""(.*)"" and Password ""(.*)"" on the login page")]
        public void WhenILogInUsingUsernameAsAndPasswordOnTheLoginPage(string username, string password)
        {
            objLogin.Login(username,password);
            Console.WriteLine($"Logged in Successfully as User : {username}");
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            objMyAccount.WaitForElementToLoad(objMyAccount.MyOrder,5);
            Assert.True(objMyAccount.IsElementDisplayedAndEnabled(objMyAccount.MyOrder));
        }

        [Then(@"I should not be logged in")]
        public void ThenIShouldNotBeLoggedIn()
        {
            objLogin.WaitForElementToLoad(objLogin.LoginErrorMessage);
            Console.WriteLine(objLogin.LoginErrorMessage.Text,Color.Red);
            Assert.True(objLogin.IsElementDisplayedAndEnabled(objLogin.LoginErrorMessage));
               
        }

    }
}
