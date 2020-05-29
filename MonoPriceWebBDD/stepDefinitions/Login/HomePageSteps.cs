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
    public class HomePageSteps
    {
        private readonly string baseUrl = ScenarioContext.Current["baseUrl"].ToString();


        IWebDriver driver;
        LoginPage objLogin;
        MyAccountPage objMyAccount;
        HomePage objHomePage;
        
        public HomePageSteps(IWebDriver Driver)
        {
            driver = Driver;
            objLogin = new LoginPage(driver);
            objMyAccount = new MyAccountPage(driver);
            objHomePage = new HomePage(driver);

        }

        [Then(@"I Open any Product Page")]
        public void ThenIOpenAnyProductPage()
        {
            objHomePage.JavaScriptClick(objHomePage.CompanyLogo);
            objHomePage.JavaScriptClick(objHomePage.ShopMonoPriceButton);
            objHomePage.JavaScriptClick(objHomePage.Cables);
            objHomePage.JavaScriptClick(objHomePage.HdmiCables);
            objHomePage.JavaScriptClick(objHomePage.AddToCart_9303);
            objHomePage.WaitForElementToLoad(objHomePage.Checkout,20);
            objHomePage.JavaScriptClick(objHomePage.Checkout);
            objHomePage.JavaScriptClick(objHomePage.ProceedToCheckout);
            objHomePage.CVV.SendKeys("786");
            objHomePage.JavaScriptClick(objHomePage.PlaceOrder);
            var orderid=objHomePage.OrderNumber.Text;
            Console.WriteLine(orderid);

        }


    }
}
