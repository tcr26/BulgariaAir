using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using BulgariaAir;

namespace BulgariaAir.BulgariaAirTitleTest
{
    [Binding]
    public class BulgariaAirPageTitleTest
    {
        private static WebDriverWait Waiter { get; set; }

        public BulgariaAirPageTitleTest()
        {
            Waiter = new WebDriverWait(Hooks.Driver, TimeSpan.FromSeconds(20));
        }

        [Given(@"I am on the ""(.*)"" page url")]
        public void GivenNavigateToPage(string pageURL)
        {
            Hooks.Driver.Navigate().GoToUrl(pageURL);
        }

        [Then(@"I check for ""(.*)"" page title")]
        public void ThenCheckForPageTitle(string pageTitle)
        {
            Assert.AreEqual(pageTitle, Hooks.Driver.Title);
        }
    }
}
