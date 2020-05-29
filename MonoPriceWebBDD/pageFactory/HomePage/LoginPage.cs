using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MonoPriceWebBDD.pageFactory.HomePage
{
    public class LoginPage :BaseClass
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//input[@title='Email Address']")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@title='Password']")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@title='Sign In']")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='message']")]
        public IWebElement LoginErrorMessage { get; set; }

        

        internal void Login(string username, string password)
        {
            SetUserName(username);
            SetPassword(password);        
            SignInButton.Click();

        }

        private void SetPassword(string password)
        {
            WaitForElementToLoad(Password);
            Password.Clear();
            Password.SendKeys(password);
        }

        private void SetUserName(string username)
        {
            WaitForElementToLoad(UserName);
            UserName.Clear();
            UserName.SendKeys(username);
        }
    }
}
