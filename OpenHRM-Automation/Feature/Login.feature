Feature: Login

Checking the Login feature with valid creds
As a admin
I would like to access orange hrm portal

Background: 
Given I have a browser open with OrangeHRM Website loaded
Scenario: Validlogin
	
	When I enter valid username as 'Admin'
	And I enter valid password as 'admin123'
	And I click on login button
	Then I should get access to Dashboard page with 'Quick launch' text


	Scenario Outline: InValidlogin

	When I enter valid username as '<username>'
	And I enter valid password as '<password>'
	And I click on login button
	Then I should not get access to Dashboard page with error message as '<expectedError>' text
	Examples: 
	| username | password | expectedError       |
	| pranay   | password | Invalid Credentials |
	| JIM      | HALPERT  | Invalid Credentials |

