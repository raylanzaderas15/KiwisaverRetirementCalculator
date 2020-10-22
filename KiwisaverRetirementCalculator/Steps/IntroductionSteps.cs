using System;
using KiwisaverRetirementCalculator.Pages;
using KiwisaverRetirementCalculator.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KiwisaverRetirementCalculator.Steps
{
    [Binding]
    public class IntroductionSteps
    {
        private IntroductionPage _introductionpage;
        
        public IntroductionSteps (IntroductionPage introductionPage) 
        {
            _introductionpage = introductionPage;
        }

        [Given("the user clicks '(.*)' on '(.*)' page")]
        [When("the user clicks '(.*)' on '(.*)' page")]
        [Then("the user clicks '(.*)' on '(.*)' page")]
        public void TheUserClicksLinkOnSection(string linkOrButtonToClick, string page)
        {
            switch (page.ToUpper())
            {
                case "CALCULATOR, FEES & TOOLS":
                    switch (linkOrButtonToClick.ToUpper())
                    {
                        case "KIWISAVER CALCULATOR LINK":
                            _introductionpage.ClickKiwisaverCalculatorLink();
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                    break;
                case "WESTPAC KIWISAVER SCHEME RISK PROFILER AND RETIREMENT CALCULATOR":
                    switch (linkOrButtonToClick.ToUpper())
                    {
                        case "CLICK HERE TO GET STARTED BUTTON":
                            _introductionpage.ClickClickHereToGetStartedButton();
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                    break;
                case "KIWISAVER RETIREMENT CALCULATOR":
                    switch (linkOrButtonToClick.ToUpper())
                    {
                        case "CURRENT AGE HELP INFO":
                            _introductionpage.ClickCurrentAgeHelpInfo();
                            break;
                        case "VIEW YOUR KIWISAVER RETIREMENT PROJECTIONS":
                            _introductionpage.ClickViewYourKiwisaverRetirementProjectButton();
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                    break;
            }
        }

        [Given("the user lands on '(.*)' page")]
        public void TheUserLandsOnPage(string landingToCheck)
        {
            switch (landingToCheck.ToUpper())
            {
                case "WESTPAC KIWISAVER SCHEME RISK PROFILER AND RETIREMENT CALCULATOR":
                    Assert.AreEqual(Constants.WESTPACSCHEMECALCULATOR_PAGE, _introductionpage.LandedOnKiwisaverSchemeRiskProfilerAndRetirementCalculatorPage(), "Failed to land on Kiwisaver Page");
                    break;
                case "KIWISAVER RETIREMENT CALCULATOR":
                    Assert.AreEqual(Constants.KIWISAVERCALCULATOR_PAGE, _introductionpage.LandedOnKiwisaverCalculatorPage(), "Failed to land on Kiwisaver Calculator Page");
                    break;
            }
        }

        [Then("the current age limit callout should be displayed")]
        public void TheCurrentAgeLimitCalloutShouldBeDisplayed()
        {
            Assert.AreEqual(Constants.CURRENTAGELIMIT_CALLOUT, _introductionpage.CurrentAgeLimitHelpInfo(), "Failed to valdiate current age limit callout");
        }
    }
}
