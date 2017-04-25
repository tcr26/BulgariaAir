using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using BulgariaAir;
using BulgariaAir.BulgariaAirSearchForFlightTests;

namespace BulgariaAir.BulgariaAirSearchForFlightTests
{
    [Binding]

    public class BulgariaAirSearchForFlight
    {
        private static WebDriverWait Waiter { get; set; }

        public BulgariaAirSearchForFlight()
        {
            Waiter = new WebDriverWait(Hooks.Driver, TimeSpan.FromSeconds(20));
            Flight = new BulgariaAirHomePage();
            PageFactory.InitElements(Hooks.Driver, Flight);
        }

        public BulgariaAirHomePage Flight { get; set; }

        [Given(@"I am on the BulgariaAir home page")]
        public void GivenIAmOnTheBulgariaAirHomePage()
        {
            Hooks.Driver.Navigate().GoToUrl("https://www.air.bg/en");
        }

        [Then(@"I select Varna Airport")]
        public void ThenISelectVarnaAirport()
        {
            Flight.FlightFromElement.Click();

            var divId = Hooks.Driver.FindElement(By.Id("B_LOCATION_1_chosen")).FindElement(By.ClassName("chosen-results")).FindElements(By.ClassName("active-result"));

            foreach (var item in divId)
            {
                if (item.Text == "Varna, Bulgaria (VAR)")
                {
                    item.Click();
                }
            }
        }

        [Then(@"I select Milan Airport")]
        public void ThenISelectMilanAirport()
        {
            Flight.FlightToElement.Click();

            var toAirPortInputElement = Hooks.Driver.FindElement(By.XPath("html/body/div/header/div[1]/div[3]/div[1]/form/ol/li[2]/div/div/div/div/input"));
            toAirPortInputElement.Click();
            //toAirPortInputElement.SendKeys("Milan");

            var divId = Hooks.Driver.FindElement(By.Id("E_LOCATION_1_chosen")).FindElement(By.ClassName("chosen-results")).FindElements(By.ClassName("active-result"));

            foreach (var item in divId)
            {
                if (item.Text == "Milan, Italy (MXP)")
                {
                    item.Click();
                }
            }
        }

        [Then(@"I Choose one way ticket")]
        public void ThenIChooseOneWayTicket()
        {
            Flight.OneWayTicketOptionElement.Click();
        }

        [Then(@"i want to depart at (.*)")]
        public void ThenIWantToDepartAt(int p0)
        {
            Flight.DepartingDateElement.Click();
            Waiter.Until(ExpectedConditions.ElementIsVisible(By.ClassName("datepick-popup")));
            var datePickMonth = Hooks.Driver.FindElement(By.ClassName("datepick-month")).FindElement(By.TagName("table")).FindElement(By.TagName("tbody"));
            var datesElements = datePickMonth.FindElements(By.TagName("td"));

            foreach (var item in datesElements)
            {
                if (item.Text == "30")
                {
                    item.Click();
                    break;
                }
            }
        }

        //[Then(@"I choose Economy ticket")]
        //public void ThenIChooseEconomyTicket()
        //{
        //    Flight.DropDownSelectElements(Flight.TicketTypeElement, "E");
        //}

        //[Then(@"I select (.*) adult")]
        //public void ThenISelectAdult()
        //{
        //    Flight.DropDownSelectElements(Flight.NumberOfAdultsElement, "1");
        //}

        //[Then(@"I Select (.*) children")]
        //public void ThenISelectChildren()
        //{
        //    Flight.DropDownSelectElements(Flight.NumberOfChildrensElement, "0");
        //}

        //[Then(@"I select (.*) infants")]
        //public void ThenISelectInfants()
        //{
        //    Flight.DropDownSelectElements(Flight.NumberOfInfantsElement, "0");
        //}

        //[When(@"I click on Search Button")]
        //public void WhenIClickOnSearchButton()
        //{
        //    Flight.SearchForFlightButtonElement.Click();
        //}
    }
}
