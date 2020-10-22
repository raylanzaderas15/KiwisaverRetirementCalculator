// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace KiwisaverRetirementCalculator.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("01_Introduction")]
    public partial class _01_IntroductionFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "01_Introduction.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "01_Introduction", "\tAs a Product Owner \n\tI want that while using the KiwiSaver Retirement Calculator" +
                    " all fields in the calculator have got the information icon present\n\tSo that the" +
                    " user is able to get a clear understanding of what needs to be entered in the fi" +
                    "eld", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify retirement calculator age limit help info message")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void VerifyRetirementCalculatorAgeLimitHelpInfoMessage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify retirement calculator age limit help info message", null, new string[] {
                        "regression"});
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
 testRunner.Given("the user lands on Westpac homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
  testRunner.And("the user clicks \'KiwiSaver calculator link\' on \'Calculator, fees & tools\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
  testRunner.And("the user lands on \'Westpac KiwiSaver Scheme Risk Profiler and Retirement Calculat" +
                    "or\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
  testRunner.And("the user clicks \'Click here to get started button\' on \'Westpac KiwiSaver Scheme R" +
                    "isk Profiler and Retirement Calculator\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
  testRunner.And("the user lands on \'KiwiSaver Retirement Calculator\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("the user clicks \'Current Age Help Info\' on \'KiwiSaver Retirement Calculator\' page" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("the current age limit callout should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
