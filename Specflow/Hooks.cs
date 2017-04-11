using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Specflow
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
