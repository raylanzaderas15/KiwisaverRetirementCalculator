using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace KiwisaverRetirementCalculator.Pages
{

    public class CalculationsPage : BasePage
    {
        public CalculationsPage(IWebDriver driver) : base(driver)
        {
            driver.SwitchTo().DefaultContent();
            InitRiskProfiles();
            InitMemberContributions();
        }

        private By _ageField = By.XPath("//*[@help-id='CurrentAge']//input");
        private By _switchIframe = By.XPath("//*[@id='calculator-embed']/iframe");
        private By _employmentStatusField = By.XPath("//*[@help-id='EmploymentStatus']//*[@class='well-value ng-binding']");
        private By _employedStatus = By.XPath("//*[@class='option-list']/li[@value='employed']");
        private By _selfEmployedStatus = By.XPath("//*[@class='option-list']/li[@value='self-employed']");
        private By _nonEmployedStaus = By.XPath("//*[@class='option-list']/li[@value='not-employed']");
        private By _currentKiwisaverBalance = By.XPath("//*[@help-id='KiwiSaverBalance']//input");
        private By _voluntaryContributions = By.XPath("//*[@help-id='VoluntaryContributions']//input");
        private By _contributionField = By.XPath("//*[@help-id='VoluntaryContributions']//*[@class='well-value ng-binding']");
        private By _weeklyFrequency = By.XPath("//*[@class='option-list']/li[@value='week']");
        private By _fortnighlyFrequency = By.XPath("//*[@class='option-list']/li[@value='fortnight']");
        private By _monthlyFrequency = By.XPath("//*[@class='option-list']/li[@value='month']");
        private By _annuallyFrequency = By.XPath("//*[@class='option-list']/li[@value='year']");
        private By _goalRetirement = By.XPath("//*[@help-id='SavingsGoal']//input");
        private By _annualIncome = By.XPath("//*[@help-id='AnnualIncome']//input");
        private By _threePercent = By.XPath("//div[@value='3']");
        private By _fourPercent = By.XPath("//div[@value='4']");
        private By _sixPercent = By.XPath("//div[@value='6']");
        private By _eightPercent = By.XPath("//div[@value='8']");
        private By _tenPercent = By.XPath("//div[@value='10']");
        private By _defensiveRisk = By.XPath("//div[@value='low']");
        private By _conservativeRisk = By.XPath("//div[@value='medium']");
        private By _balancedRisk = By.XPath("//div[@value='high']");
        private By _growthRisk = By.XPath("//div[@value='growth']");
        private By _kiwisaverBalanceAmount = By.XPath("//*[@class='result-value result-currency ng-binding']");


        public void EnterCurrentAge(string ageValue)
        {
            SwitchFrame(_switchIframe);
            EnterValues(_ageField, ageValue);
        }

        public void SelectEmploymentStatus(string status)
        {
            SwitchFrame(_switchIframe);
            ClickElement(_employmentStatusField);
            switch (status.ToUpper())
            {
                case "EMPLOYED":
                    ClickElement(_employedStatus);
                    break;
                case "SELF-EMPLOYED":
                    ClickElement(_selfEmployedStatus);
                    break;
                case "NOT EMPLOYED":
                    ClickElement(_nonEmployedStaus);
                    break;
            }
        }

        public void EnterCurrentKiwisaverBalance(string amount)
        {
            EnterValues(_currentKiwisaverBalance, amount);
        }

        public void SelectRiskProfile(string riskOption)
        {
            Action action = null;
            var isActionFound = InitRiskProfiles().TryGetValue(riskOption.ToUpper(), out action);
            if (!isActionFound)
            {
                throw new Exception("Risk option not found");
            }

            action.Invoke();
        }

        public void EnterSavingsGoalAtRetirement(string amountGoal)
        {
            EnterValues(_goalRetirement, amountGoal);
        }

        public void EnterSalaryOrWage(string ageValue)
        {
            SwitchFrame(_switchIframe);
            EnterValues(_annualIncome, ageValue);
        }

        public void SelectMemberContribution(string memberContributions)
        {
            Action action = null;
            var isActionFound = InitMemberContributions().TryGetValue(memberContributions.ToUpper(), out action);
            if (!isActionFound)
            {
                throw new Exception("Member Contribution not found");
            }

            action.Invoke();
        }

        public bool VerifyKiwisaverEstimatedBalance()
        {

            SwitchFrame(_switchIframe);
            return VerifyElement(_kiwisaverBalanceAmount);
        }


        private Dictionary<string, Action> InitMemberContributions()
        {
            Dictionary<string, Action> memberContributions = new Dictionary<string, Action>();
            memberContributions.Add("3%", () => ClickElement(_threePercent));
            memberContributions.Add("4%", () => ClickElement(_fourPercent));
            memberContributions.Add("6%", () => ClickElement(_sixPercent));
            memberContributions.Add("8%", () => ClickElement(_eightPercent));
            memberContributions.Add("10%", () => ClickElement(_tenPercent));
            return memberContributions;
        }

        private Dictionary<string, Action> InitRiskProfiles()
        {
            Dictionary<string, Action> riskProfiles = new Dictionary<string, Action>();
            riskProfiles.Add("DEFENSIVE", () => ClickElement(_defensiveRisk));
            riskProfiles.Add("CONSERVATIVE", () => ClickElement(_conservativeRisk));
            riskProfiles.Add("BALANCED", () => ClickElement(_balancedRisk));
            riskProfiles.Add("GROWTH", () => ClickElement(_growthRisk));
            return riskProfiles;
        }

        public void EnterVoluntaryContributionAndFrequency(string contributionAmount, string contributionFrequncy)
        {
            EnterValues(_voluntaryContributions, contributionAmount);
            WaitForPage();
            ClickElement(_contributionField);
            switch (contributionFrequncy.ToUpper())
            {
                case "WEEKLY":
                    ClickElement(_weeklyFrequency);
                    break;
                case "FORTNIGHTLY":
                    ClickElement(_fortnighlyFrequency);
                    break;
                case "MONTHLY":
                    ClickElement(_monthlyFrequency);
                    break;
                case "ANNUALLY":
                    ClickElement(_annuallyFrequency);
                    break;
            }
        }

    }
}