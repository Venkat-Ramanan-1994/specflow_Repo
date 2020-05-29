using log4net;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MonoPriceWebBDD.stepDefinitions.util
{
    [Binding]
    public class CommonSteps
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        IWebDriver driver;
        IWebElement locator = null;     
        private string url;
        private int defaultTimeOutSeconds;
        private bool performanceLogging;
        private string[] featureTags;
        private string[] scenarioTags;
        public static string website { get; set; }


        public CommonSteps(IWebDriver Driver)
        {
            driver = Driver;
           
            featureTags = FeatureContext.Current.FeatureInfo.Tags;
            scenarioTags = ScenarioContext.Current.ScenarioInfo.Tags;
            defaultTimeOutSeconds = Convert.ToInt32(ConfigurationManager.AppSettings["defaultTimeOutSeconds"]);
          
            
        }

        [Given(@"I open the ""(.*)"" website's login page")]
        public void GivenIOpenTheWebsite(string app)
        {
            string baseUrl = null;
            string env = ConfigurationManager.AppSettings["env"].ToLower();

            switch (app)
            {
                case "MonoPrice Admin Portal":
                    app = "admin";
                    baseUrl = getEnvUrl(app, env);
                    break;
                case "Monoprice Web":
                    app = "web";
                    baseUrl = getEnvUrl(app, env);
                    break;               
                default:
                    throw new AppDomainUnloadedException("Unknown application: " + app);
            }

            String url = baseUrl;
            var browser = ConfigurationManager.AppSettings["defaultBrowser"].ToLower();
            logger.Debug("Browser navigating to " + url);
            driver.Navigate().GoToUrl(url);
            Console.WriteLine("Browser navigating to " + url);
            ScenarioContext.Current["baseUrl"] = baseUrl;

            website = app;
        }


        public static string getEnvUrl(string website, string env)
        {
            string domain = null;
            var browser = ConfigurationManager.AppSettings["defaultBrowser"].ToLower();
            string url= ConfigurationManager.AppSettings["url"].ToLower();
            switch (env.ToLower())
            {
                case "qa1":
                    if (website.Equals("web"))
                    {
                        
                        domain = $"https://{env}.{url}";
                    }
                    else if (website.Equals("admin"))
                    {
                        domain = $"https://{env}intranet.{url}";
                    }
                    break;
                case "qa2":
                    if (website.Equals("web"))
                    {

                        domain = $"https://{env}.{url}";
                    }
                    else if (website.Equals("admin"))
                    {
                        domain = $"https://{env}intranet.{url}";
                    }
                    break;
                case "stg1":
                    if (website.Equals("web"))
                    {

                        domain = $"https://{env}.{url}";
                    }
                    else if (website.Equals("admin"))
                    {
                        domain = $"https://{env}intranet.{url}";
                    }
                    break;
                case "stg2":
                    if (website.Equals("web"))
                    {

                        domain = $"https://{env}.{url}";
                    }
                    else if (website.Equals("admin"))
                    {
                        domain = $"https://{env}intranet.{url}";
                    }
                    break;
                case "prod":
                    if (website.Equals("web"))
                    {

                        domain = $"https://{url}";
                    }
                    else if (website.Equals("admin"))
                    {
                        domain = $"https://intranet.{url}";//Need to check
                    }
                    break;
                default:
                    break;
            }
            return domain;
        }

    }
}
