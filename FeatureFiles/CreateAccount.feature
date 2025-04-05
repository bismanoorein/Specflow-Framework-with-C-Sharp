Feature: Create Account

Scenario:Create Account with valid credentials
Given I navigate to given website
	And I click on Create an Account Link
	And I Enter First Name as "John"
	And I Enter Last Name as "Doe"
	And I Enter Email as "bisma.test@gmail.com"
	And I Enter Password as "Test123@"
	And I Enter Confirm Password as "Test123@"
	Then I Click on Create an Account button
	And I see My Account text    


Scenario: Create Account with invalid email id 
    Given I navigate to given website
	And I click on Create an Account Link
	And I Enter First Name as "John"
	And I Enter Last Name as "Doe"
	And I Enter Email as "bisma.test_test@gmail"
	And I Enter Password as "Test123@"
	And I Enter Confirm Password as "Test123@"
	Then I Click on Create an Account button
	And I see error text

Scenario: Create Account with duplicate email id
Given I navigate to given website
	And I click on Create an Account Link
	And I Enter First Name as "John"
	And I Enter Last Name as "Doe"
	And I Enter duplicate Email as "bisma.test@gmail.com"
	And I Enter Password as "Test123@"
	And I Enter Confirm Password as "Test123@"
	Then I Click on Create an Account button
	And I see message error duplcate email error text

Scenario: Create Account with password mismatch
Given I navigate to given website
	And I click on Create an Account Link
	And I Enter First Name as "John"
	And I Enter Last Name as "Doe"
	And I Enter Email as "bisma.test_test@gmail.com"
	And I Enter Password as "Test123@"
	And I Enter Confirm Password as "Test1"
	Then I Click on Create an Account button
	And I see password mismatch error


