﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SeFramework.FeatureFiles
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Create Account")]
    [NUnit.Framework.FixtureLifeCycleAttribute(NUnit.Framework.LifeCycle.InstancePerTestCase)]
    public partial class CreateAccountFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FeatureFiles", "Create Account", null, global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "CreateAccount.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Account with valid credentials")]
        public async System.Threading.Tasks.Task CreateAccountWithValidCredentials()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Create Account with valid credentials", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 4
await testRunner.GivenAsync("I navigate to given website", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 5
 await testRunner.AndAsync("I click on Create an Account Link", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 6
 await testRunner.AndAsync("I Enter First Name as \"John\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 7
 await testRunner.AndAsync("I Enter Last Name as \"Doe\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 8
 await testRunner.AndAsync("I Enter Email as \"bisma.test@gmail.com\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 9
 await testRunner.AndAsync("I Enter Password as \"Test123@\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 10
 await testRunner.AndAsync("I Enter Confirm Password as \"Test123@\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 11
 await testRunner.ThenAsync("I Click on Create an Account button", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 12
 await testRunner.AndAsync("I see My Account text", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Account with invalid email id")]
        public async System.Threading.Tasks.Task CreateAccountWithInvalidEmailId()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Create Account with invalid email id", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 16
    await testRunner.GivenAsync("I navigate to given website", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 17
 await testRunner.AndAsync("I click on Create an Account Link", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 18
 await testRunner.AndAsync("I Enter First Name as \"John\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 19
 await testRunner.AndAsync("I Enter Last Name as \"Doe\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 20
 await testRunner.AndAsync("I Enter Email as \"bisma.test_test@gmail\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 21
 await testRunner.AndAsync("I Enter Password as \"Test123@\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 22
 await testRunner.AndAsync("I Enter Confirm Password as \"Test123@\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 23
 await testRunner.ThenAsync("I Click on Create an Account button", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 24
 await testRunner.AndAsync("I see error text", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Account with duplicate email id")]
        public async System.Threading.Tasks.Task CreateAccountWithDuplicateEmailId()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Create Account with duplicate email id", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 26
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 27
await testRunner.GivenAsync("I navigate to given website", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 28
 await testRunner.AndAsync("I click on Create an Account Link", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 29
 await testRunner.AndAsync("I Enter First Name as \"John\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 30
 await testRunner.AndAsync("I Enter Last Name as \"Doe\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 31
 await testRunner.AndAsync("I Enter duplicate Email as \"bisma.test@gmail.com\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 32
 await testRunner.AndAsync("I Enter Password as \"Test123@\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 33
 await testRunner.AndAsync("I Enter Confirm Password as \"Test123@\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 34
 await testRunner.ThenAsync("I Click on Create an Account button", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 35
 await testRunner.AndAsync("I see message error duplcate email error text", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Account with password mismatch")]
        public async System.Threading.Tasks.Task CreateAccountWithPasswordMismatch()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Create Account with password mismatch", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 38
await testRunner.GivenAsync("I navigate to given website", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 39
 await testRunner.AndAsync("I click on Create an Account Link", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 40
 await testRunner.AndAsync("I Enter First Name as \"John\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 41
 await testRunner.AndAsync("I Enter Last Name as \"Doe\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 42
 await testRunner.AndAsync("I Enter Email as \"bisma.test_test@gmail.com\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 43
 await testRunner.AndAsync("I Enter Password as \"Test123@\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 44
 await testRunner.AndAsync("I Enter Confirm Password as \"Test1\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 45
 await testRunner.ThenAsync("I Click on Create an Account button", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 46
 await testRunner.AndAsync("I see password mismatch error", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
