Feature: Login
	Login to EA Demo Application


@smoke
Scenario: Perform Login of EA Application Site
	Given I launch the application
	And I click login link
	And I enter the following details
		| UserName | Password |
		| admin    | password |	
	And I click login button
	Then I should see Employee details link