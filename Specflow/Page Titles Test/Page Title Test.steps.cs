using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace Specflow
{
    [Binding]
    public class GoToPage
    {
        private static WebDriverWait Waiter { get; set; }

        public GoToPage()
        {
            Waiter = new WebDriverWait(Hooks.Driver, TimeSpan.FromSeconds(20));
        }

        [Given(@"Navigate to ""(.*)""")]
        public void GivenNavigateTo(string pageUrl)
        {
            Hooks.Driver.Navigate().GoToUrl(pageUrl);
        }

        [Then(@"Check for ""(.*)""")]
        public void ThenCheckFor(string pageTitle)
        {
            Assert.AreEqual(pageTitle, Hooks.Driver.Title);
        }
    }
}
