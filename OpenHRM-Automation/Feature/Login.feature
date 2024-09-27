Feature: Login

Checking the Login feature with valid creds
As a admin
I would like to access orange hrm portal

Scenario: Validlogin
	Given I have a browser open with OrangeHRM Website loaded
	When I enter valid username as 'Admin'
	And I enter valid password as 'admin123'
	And I click on login button
	Then I should get access to Dashboard page with 'Quick launch' text

	
	Scenario: InValidlogin
	Given I have a browser open with OrangeHRM Website loaded
	When I enter valid username as 'ddmin'
	And I enter valid password as 'Admin123'
	And I click on login button
	Then I should not get access to Dashboard page with error message as 'Invalid Credentials' text