using System;
using BoDi;
using KiwisaverRetirementCalculator.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace KiwisaverRetirementCalculator.Steps
{
    [Binding]
    public class GenericStep
    {
        private IWebDriver driver;
        public string westpacURL;
        private readonly IObjectContainer _objectContainer;

        public GenericStep(ObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        private void initPages()
        {
            driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
            _objectContainer.RegisterInstanceAs<IntroductionPage>(new IntroductionPage(driver));
            _objectContainer.RegisterInstanceAs<CalculationsPage>(new CalculationsPage(driver));
        }

        [BeforeScenario]
        public void SetupTest()
        {
            westpacURL = "https://www.westpac.co.nz";
            initPages();
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void CleanUp()
        { 
            driver.Close();
        }

        [Given("the user lands on Westpac homepage")]
        public void TheUserLandsOnWestpacHomepage()
        {
            driver.Navigate().GoToUrl(westpacURL);
            WebDriverWait wait = new WebDriverWait(driver,
            TimeSpan.FromSeconds(15));
            wait.Until(driver =>
            driver.FindElement(By.XPath("//a[@class='sw-header-logo']")));
        }
    }
}