Feature: Consultant reports time
	As a consultant
	I want to report my time
	So that I can charge my client accuratly

Scenario: Regular working day
	When a consultant reports 8 hours
	Then the time report for that day should state 8 hours