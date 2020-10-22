using System;
using KiwisaverRetirementCalculator.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace KiwisaverRetirementCalculator.Steps
{
    [Binding]
    public class CalculationsSteps
    {
        private CalculationsPage _calculationsPage;

        public CalculationsSteps(CalculationsPage calculationsPage)
        {
            _calculationsPage = calculationsPage;
        }

        [When("the user enters '(.*)' as Current Age")]
        public void TheUserEntersAsCurrentAge(string currentAge)
        {
            _calculationsPage.EnterCurrentAge(currentAge);
        }

        [When("the user selects '(.*)' as Employment Status")]
        public void TheUserEntersAsEmploymentStatus(string status)
        {
            _calculationsPage.SelectEmploymentStatus(status);
        }

        [When("the user enters '(.*)' as Current KiwiSaver Balance")]
        public void TheUserEnterAsCurrentKiwisaverBalance (string amount)
        {
            _calculationsPage.EnterCurrentKiwisaverBalance(amount);
        }

        [When("the user enters '(.*)' as Voluntary contributions and selects '(.*)' as Frequency")]
        public void TheUserEntersAsVoluntaryContributionsAndSelectsAsFrequency(string contributionAmount, string contributionFrequncy)
        {
            _calculationsPage.EnterVoluntaryContributionAndFrequency(contributionAmount, contributionFrequncy);
        }

        [When("the user selects '(.*)' as Risk Profile")]
        public void TheUserSelectsAsRiskProfile(string riskOption)
        {
            _calculationsPage.SelectRiskProfile(riskOption);
        }

        [When("the user enters '(.*)' as Savings goal at retirement")]
        public void TheUserEntersAsSAvingsGoalAtRetirement(string amountGoal)
        {
            _calculationsPage.EnterSavingsGoalAtRetirement(amountGoal);
        }

        [When("the user enters '(.*)' as Salary Or Wages per year")]
        public void TheUserEntersAsSalaryOrWagesPerYear(string amountSalary)
        {
            _calculationsPage.EnterSalaryOrWage(amountSalary);
        }

        [When("the user selects '(.*)' as Kiwisaver member contribution")]
        public void TheUSerSelectsAsKiwisaverMemberContribution(string contribution)
        {
            _calculationsPage.SelectMemberContribution(contribution);
        }

        [Then("the Estimated Kiwisaver should be displayed")]
        public void TheEstimatedKiwisaverBalanceShouldBeDisplayed()
        {
            Assert.IsTrue(_calculationsPage.VerifyKiwisaverEstimatedBalance());
        }
    }
}