using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace KiwisaverRetirementCalculator.Pages
{
    public class BasePage
    {
        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void WaitForPage()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            
        }
  
        public IWebElement FindElement(By locator)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            return wait.Until<IWebElement>(driver =>
            {
                IWebElement tempElement = driver.FindElement(locator);
                return (tempElement.Displayed && tempElement.Enabled) ? tempElement : null;
            }
        );
            
        }

        public List<IWebElement> FindElements(By locator)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            return wait.Until(drv => drv.FindElements(locator)).ToList();
        }
        public void ClickElement(By locator)
        {
            FindElement(locator).Click();
        }

        public void ClearText(By locator)
        {
            FindElement(locator).Clear();
        }

        public bool VerifyElement(By locator)
        {
            return FindElement(locator).Displayed;
        }

        public void EnterText(By locator, string value)
        {
            FindElement(locator).SendKeys(value);
        }

        public string GetText(By locator)
        {
           return FindElement(locator).Text; 
        }

        public void EnterValues(By locator, string value)
        {
            FindElement(locator).Click();
            FindElement(locator).Clear();
            FindElement(locator).SendKeys(value);
        }

        public void SwitchFrame(By locator)
        {
            Driver.SwitchTo().ParentFrame();
            Driver.SwitchTo().Frame(Driver.FindElement(locator));
        }
    }
}