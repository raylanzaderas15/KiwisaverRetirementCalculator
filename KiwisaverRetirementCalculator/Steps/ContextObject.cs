using System;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace KiwisaverRetirementCalculator.DataModel
{
    public class ContextObject
    {
        public IWebDriver Driver { get; set; }

        public ContextObject(IWebDriver driver)
        {
            Driver = driver;

        }
    }

    
}
