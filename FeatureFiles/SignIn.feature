Feature: Signin

Scenario: Login to website using valid credentials
	Given I navigate to given website
	Then I click on Log In button
	And I enter email as "bisma.test@gmail.com" and password as "Test@123"
	And I click on Login button
	Then I should see the Dashboard tab
	Then I close the browser instance