using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using BulgariaAir.BulgariaAirSearchForFlightTests;
using OpenQA.Selenium.Edge;

namespace BulgariaAir
{
    [Binding]
    public static class Hooks
    {
        public static IWebDriver Driver { get; set; }

        [BeforeScenario]
        public static void BeforeScenario()
        {

        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Driver = new FirefoxDriver();
            Driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Driver.Dispose();
        }
    }
}
