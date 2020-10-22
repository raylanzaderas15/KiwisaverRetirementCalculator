using System;
using TechTalk.SpecFlow;
using KiwisaverRetirementCalculator.DataModel;
using OpenQA.Selenium;


namespace KiwisaverRetirementCalculator.Steps
{
    public class BaseSteps
    {
        public IWebDriver Driver { get; set; }

        public BaseSteps(IWebDriver driver)
        {
           Driver = driver;
           
        }
    }
}
