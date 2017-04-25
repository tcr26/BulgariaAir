using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace BulgariaAir.BulgariaAirSearchForFlightTests
{
    public class BulgariaAirHomePage
    {
        [FindsBy(How = How.Id, Using = "B_LOCATION_1_chosen")]
        public IWebElement FlightFromElement { get; set; }

        [FindsBy(How = How.Id, Using = "chosen-results")]
        public IWebElement FlightFromSelectElement { get; set; }

        [FindsBy(How = How.Id, Using = "E_LOCATION_1_chosen")]
        public IWebElement FlightToElement { get; set; }

        [FindsBy(How = How.Id, Using = "E_LOCATION_1")]
        public IWebElement FlightToSelectElement { get; set; }

        [FindsBy(How = How.Id, Using = "from_date")]
        public IWebElement DepartingDateElement { get; set; }

        [FindsBy(How = How.Name, Using = "DATE_RANGE_VALUE_1")]
        public IWebElement DepartingDayRangeElement { get; set; }

        [FindsBy(How = How.Id, Using = "to_date")]
        public IWebElement ReturningDateElement { get; set; }

        [FindsBy(How = How.Name, Using = "DATE_RANGE_VALUE_2")]
        public IWebElement ReturningDayRangeElement { get; set; }

        [FindsBy(How = How.Id, Using = "two_way")]
        public IWebElement TwoWayTicketOptionElement { get; set; }

        [FindsBy(How = How.Id, Using = "one_way")]
        public IWebElement OneWayTicketOptionElement { get; set; }

        [FindsBy(How = How.Name, Using = "CABIN")]
        public IWebElement TicketTypeElement { get; set; }

        [FindsBy(How = How.Id, Using = "ADTPAX")]
        public IWebElement NumberOfAdultsElement { get; set; }

        [FindsBy(How = How.Id, Using = "CHDPAX")]
        public IWebElement NumberOfChildrensElement { get; set; }

        [FindsBy(How = How.Id, Using = "InfantPAX")]
        public IWebElement NumberOfInfantsElement { get; set; }

        [FindsBy(How = How.ClassName, Using = "search")]
        public IWebElement SearchForFlightButtonElement { get; set; }
    }
}
