Feature: Adding
	

Scenario: Add two numbers
	Given I have started the calculator
	When I enter the number "1"
	And I press the "+" button
	And I enter the number "2"
	When I hit the "=" button
	Then the result should be "3"