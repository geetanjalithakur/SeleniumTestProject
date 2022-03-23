Feature: Login
	Check if login functionality works

@mytag
Scenario: Login user as Standard_User
	Given I navigate to application
	And I enter username and password
		| UserName | Password |
		| standard_user   | secret_sauce    |
	And I click login
	Then I should see user logged in to the application
