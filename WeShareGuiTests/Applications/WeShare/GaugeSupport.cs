using System;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WeShare
{
    public class GaugeSupport
    {
        private static IWebDriver? _driver;

        public static IWebDriver? Driver { get=>_driver; private set=>_driver=value!; }


        [BeforeSpec]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");
            _driver = new ChromeDriver(options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        }

        [AfterSpec]
        public void TearDown()
        {
            _driver?.Close();
        }
    }
}