Feature: View time reports
	As a user
	I want to view all my time reports
	So that I do my actual time reporting

Scenario: A month where time reports exist
	Given a user have time reports
	When the user visits the "view time reports page"
	Then the user should see all his time reports
