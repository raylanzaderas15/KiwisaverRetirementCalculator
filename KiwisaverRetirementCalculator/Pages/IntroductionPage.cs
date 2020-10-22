using OpenQA.Selenium;

namespace KiwisaverRetirementCalculator.Pages
{

    public class IntroductionPage : BasePage
    {
        public IntroductionPage(IWebDriver driver) : base(driver)
        {
            driver.SwitchTo().DefaultContent();
        }

        private By _westPactSchemeKiwisaverCalculator = By.XPath("//*[@id='main']//*[contains(text(),'Westpac KiwiSaver Scheme Risk Profiler and Retirement Calculator')]");
        private By _kiwisaverCalculator = By.XPath("//*[@class='content-inner-header']");
        private By _helpInfo = By.XPath("//*[@label='Current age']//*[@class='message-row ng-scope']/div/p");
        private By _kiwisaverCalculatorLink = By.XPath("//*[@id='tile-pane-Links-2-ps']//*[contains(text(),'KiwiSaver calculator')]/..");
        private By _getStartedButton = By.XPath("//*[@id='main']//*[contains(text(),'Click here to get started.')]");
        private By _switchIframe = By.XPath("//*[@id='calculator-embed']/iframe");
        private By _currentAgeInfo = By.XPath("//*[@help-id='CurrentAge']//*[@help-id='CurrentAge']/../..");
        private By _viewYourKiwisaverButton = By.XPath("//*[@class='btn btn-regular btn-results-reveal btn-has-chevron']");
        private By _ageField = By.XPath("//*[@help-id='CurrentAge']//input");

        public string LandedOnKiwisaverSchemeRiskProfilerAndRetirementCalculatorPage()
        {
            WaitForPage();
            return GetText(_westPactSchemeKiwisaverCalculator);
        }

        public string LandedOnKiwisaverCalculatorPage()
        {
            WaitForPage();
            return GetText(_kiwisaverCalculator);
        }

        public string CurrentAgeLimitHelpInfo()
        {
            return GetText(_helpInfo);
        }

        public void ClickKiwisaverCalculatorLink()
        {
            WaitForPage();
            ClickElement(_kiwisaverCalculatorLink);
        }

        public void ClickClickHereToGetStartedButton()
        {
            WaitForPage();
            ClickElement(_getStartedButton);
        }

        public void ClickCurrentAgeHelpInfo()
        {
            SwitchFrame(_switchIframe);
            ClickElement(_currentAgeInfo);
        }

        public void ClickViewYourKiwisaverRetirementProjectButton()
        {
            WaitForPage();
            ClickElement(_viewYourKiwisaverButton);
        }
    }
}