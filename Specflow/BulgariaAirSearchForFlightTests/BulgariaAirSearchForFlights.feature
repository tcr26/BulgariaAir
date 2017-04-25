Feature: BulgariaAir Search For Flight
I am on BulgariaAir home page
I am looking for a flight

Scenario: Search for Flight
Given I am on the BulgariaAir home page
Then I select Varna Airport
Then I select Milan Airport
Then I Choose one way ticket
	And i want to depart at 30
#Then I choose Economy ticket
#	And I select 1 adult
#	And I Select 0 children
#	And I select 0 infants
#When I click on Search Button