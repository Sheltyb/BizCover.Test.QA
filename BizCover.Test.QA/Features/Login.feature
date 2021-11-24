Feature: Login
	In order to use the system
	As a registered user of the system
	I want to be able to log in to the system

Scenario: Sign In with an Existing User Account
	Given I am in the home page of the system
	When I select the Sign In option from the menu
	And I Sign In with my username and password
	| UserName                | Password |
	| bizcovertechnicaltests@bizcover.com.au | test1234 |
	Then I should be redirected to my Account Page
