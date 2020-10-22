Feature: 01_Introduction
	As a Product Owner 
	I want that while using the KiwiSaver Retirement Calculator all fields in the calculator have got the information icon present
	So that the user is able to get a clear understanding of what needs to be entered in the field

#Test User Story 1	
@regression
Scenario: Verify retirement calculator age limit help info message
	Given the user lands on Westpac homepage
		And the user clicks 'KiwiSaver calculator link' on 'Calculator, fees & tools' page
		And the user lands on 'Westpac KiwiSaver Scheme Risk Profiler and Retirement Calculator' page
		And the user clicks 'Click here to get started button' on 'Westpac KiwiSaver Scheme Risk Profiler and Retirement Calculator' page
		And the user lands on 'KiwiSaver Retirement Calculator' page
	When the user clicks 'Current Age Help Info' on 'KiwiSaver Retirement Calculator' page
	Then the current age limit callout should be displayed