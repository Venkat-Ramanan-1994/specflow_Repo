﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MonoPriceWebBDD.Features.Login
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Login: Login Functionality Feature", Description="    In order to place the orders\r\n    As a user of the website\r\n    I want to log" +
        " into the website", SourceFile="features\\Login\\Login.feature", SourceLine=0)]
    public partial class LoginLoginFunctionalityFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Login.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Login: Login Functionality Feature", "    In order to place the orders\r\n    As a user of the website\r\n    I want to log" +
                    " into the website", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SuccessfulLoginWithValidCredentials(string description, string site, string userName, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "web"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successful Login with Valid Credentials", null, @__tags);
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given(string.Format("I open the \"{0}\" website\'s login page", site), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.Then("I Navigate to MyAccount Login Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.When(string.Format("I log in using Username as \"{0}\" and Password \"{1}\" on the login page", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("I should be logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Successful Login with Valid Credentials, Online Portal", new string[] {
                "web"}, SourceLine=13)]
        public virtual void SuccessfulLoginWithValidCredentials_OnlinePortal()
        {
#line 7
this.SuccessfulLoginWithValidCredentials("Online Portal", "Monoprice Web", "jayakumart@unitedtechno.com", "Welcome@88", ((string[])(null)));
#line hidden
        }
        
        public virtual void UnSuccessfulLoginWithInValidCredentials(string description, string site, string userName, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "web"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("UnSuccessful Login with InValid Credentials", null, @__tags);
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 19
 testRunner.Given(string.Format("I open the \"{0}\" website\'s login page", site), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.Then("I Navigate to MyAccount Login Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.When(string.Format("I log in using Username as \"{0}\" and Password \"{1}\" on the login page", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("I should not be logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("UnSuccessful Login with InValid Credentials, Invalid Username", new string[] {
                "web"}, SourceLine=24)]
        public virtual void UnSuccessfulLoginWithInValidCredentials_InvalidUsername()
        {
#line 18
this.UnSuccessfulLoginWithInValidCredentials("Invalid Username", "Monoprice Web", "jayakuma@unitedtechno.com", "Welcome", ((string[])(null)));
#line hidden
        }
        
        public virtual void PlaceAnOrder(string description, string site, string userName, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "web"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Place an Order", null, @__tags);
#line 28
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 29
 testRunner.Given(string.Format("I open the \"{0}\" website\'s login page", site), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
 testRunner.Then("I Navigate to MyAccount Login Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.When(string.Format("I log in using Username as \"{0}\" and Password \"{1}\" on the login page", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("I Open any Product Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Place an Order, Online Portal", new string[] {
                "web"}, SourceLine=34)]
        public virtual void PlaceAnOrder_OnlinePortal()
        {
#line 28
this.PlaceAnOrder("Online Portal", "Monoprice Web", "jayakumart@unitedtechno.com", "Welcome@88", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion