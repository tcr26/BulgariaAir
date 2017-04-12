using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace Specflow.PageTitleTest
{
    [Binding]
    public class PageTitleTest
    {
        private static WebDriverWait Waiter { get; set; }

        public PageTitleTest()
        {
            Waiter = new WebDriverWait(Hooks.Driver, TimeSpan.FromSeconds(20));
        }

        [Given(@"Navigate to ""(.*)"" page url")]
        public void GivenNavigateToPage(string pageURL)
        {
            Hooks.Driver.Navigate().GoToUrl(pageURL);
        }

        [Then(@"Check for ""(.*)"" page title")]
        public void ThenCheckForPageTitle(string pageTitle)
        {
            Assert.AreEqual(pageTitle, Hooks.Driver.Title);
        }
    }
}
