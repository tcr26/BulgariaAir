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

            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //remove static from property to run all the single browser instance
            Driver = new FirefoxDriver();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Driver.Dispose();
        }
    }
}
