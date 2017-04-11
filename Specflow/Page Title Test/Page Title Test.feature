﻿Feature: Page Titles Tests
I go to Page
I check for site title to match the expected one

Scenario Outline: Check Page Titles
Given Navigate to <pageURL> 
Then Check for <pageTitle>

Examples: 

| pageURL                             | pageTitle  |
| "https://www.abv.bg/"               | "АБВ Поща" |
| "https://www.google.bg/?gws_rd=ssl" | "Google"   |
| "http://www.bing.com/"              | "Bing"     |