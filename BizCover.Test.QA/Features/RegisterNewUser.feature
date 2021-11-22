Feature: Create An Account
	In order to use the system
	As a new user of the system
	I want to be able to register as a new user to the system

Scenario: Sign In
	Given I am in the home page of the system
	When I sign in
	| EmailAddressUserName   | EmailAddressDomain | Password |
	| bizcovertechnicaltests | bizcover.com.au    | test1234 |
	Then I should be redirected to account-creation Page

Scenario: Create an account
	Given I am in the Account Creation page
	When I Register my Personal Information
	| Title | FirstName | LastName | EmailAddressUserName   | EmailAddressDomain | Password |
	| Mr    | Test      | TestLast | bizcovertechnicaltests | bizcover.com.au    | test1234 |
	And I Register my Address Details
	| FirstName | LastName | Company  | Address1      | Address2 | City   | State | PostCode | Country   | AdditionalInformation | HomePhone | MobilePhone | AssignAddressAlias |
	| Test      | TestLast | bizcover | 1 Test Street | test1234 | Sydney | NSW   | 2000     | Australia |                       |           | 0404040404  | Home               |           
	Then I should be redirected to my Account Page

