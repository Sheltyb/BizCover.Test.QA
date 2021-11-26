Feature: Create An Account
	In order to use the system
	As a new user of the system
	I want to be able to register as a new user to the system and Sign In

Scenario: Navigate to the Create a New Account Page
	Given I am in the home page of the system
	When I select the Sign In option from the menu
	Then I should see the Sign In Page

Scenario: Create a New Account
	Given I am in the Sign In Page
	When I Create An Account with a unique email
	| EmailAddress |
	| bizcovertechnicaltests.unique@bizcover.com.au |
	When I Register my Personal Information
	| Title | FirstName | LastName | EmailAddress | Password |
	| Mr    | Test      | TestLast | bizcovertechnicaltests.unique@bizcover.com.au    | test1234 |
	And I Register my Address Details
	| FirstName | LastName | Company  | Address1      | Address2 | City   | State | PostCode | Country   | AdditionalInformation | HomePhone | MobilePhone | AssignAddressAlias |
	| Test      | TestLast | bizcover | 1 Test Street | test1234 | Sydney | NSW   | 2000     | Australia |                       |           | "0404040404  | Home               |           
	And I click Create Account
	Then I should be redirected to My Account Page

Scenario: Sign In with a Newly Created Account
	Given I am in the home page of the system
	When I select the Sign In option from the menu
	And I Sign In with my username and password
	| UserName | Password |
	| bizcovertechnicaltests.unique@bizcover.com.au  | test1234 |
	Then I should be redirected to My Account Page