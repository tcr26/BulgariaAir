Feature: Bulgaria Air Page Title Tests
I am on BulgariaAir Home Page
I am checking the page title to match the expected one

Scenario Outline: Check Page Title
Given I am on the <pageURL> page url
Then I check for <pageTitle> page title

Examples: 

| pageURL                 | pageTitle                           |
| "https://www.air.bg/en" | "Airline Bulgaria Air - Home"       |
| "https://www.air.bg/bg" | "Авиокомпания България Ер - Начало" |


