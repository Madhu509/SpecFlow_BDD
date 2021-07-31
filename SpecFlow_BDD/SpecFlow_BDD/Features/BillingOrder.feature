Feature: BillingOrder
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
	
@mytag
Scenario: Billing Order Scenario
	Given Open Billing Order page
	When Enter User Details
	And Submit User Details
	Then Form Should be submitted successfully


	
@mytag
Scenario: Gmail Login
	Given Open Gmail Login Page
    When User Enter Valid Credentials
	And Submit User Details
	Then Successful Login into account