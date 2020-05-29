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
    public class HomePage : BaseClass
    {

        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public HomePage(IWebDriver driver) : base(driver)
        {


        }

        [FindsBy(How = How.XPath, Using = "//a[@title='Monoprice, Inc.']")]
        public IWebElement CompanyLogo { get; set; }


        [FindsBy(How = How.XPath, Using = "//a[@title='Shop Monoprice']")]
        public IWebElement ShopMonoPriceButton { get; set; }



        [FindsBy(How = How.XPath, Using = "//a[@title='Cables']")]
        public IWebElement Cables { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title='HDMI Cables']")]
        public IWebElement HdmiCables { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@title='Add to cart']")]
        public IWebElement AddToCart { get; set; }

        [FindsBy(How = How.Id, Using = "addtoCartQty-9303")]
        public IWebElement AddToCart_9303 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title='Checkout']")]
        public IWebElement Checkout { get; set; }


        [FindsBy(How = How.XPath, Using = "//a[@title='Proceed to Checkout']")]
        public IWebElement ProceedToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@title='CVV']")]
        public IWebElement CVV { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Place Order']")]
        public IWebElement PlaceOrder { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Order number:')]")]
        public IWebElement OrderNumber { get; set; }
        

        [FindsBy(How = How.Id, Using = "btncontinueckhkout")]
        public IWebElement ContinueOnCheckOut { get; set; }
        










    }
}
