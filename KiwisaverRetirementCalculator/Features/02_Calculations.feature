Feature: 02_Calculations
	As a Product Owner 
	I want that the KiwiSaver Retirement Calculator users are able to calculate what their KiwiSaver projected balance would be at retirement
	So that the users are able to plan their investments better.

#Test User Story 2	
@regression
Scenario Outline: Verify Kiwisaver retirement calculations_Employed Status
	Given the user lands on Westpac homepage
		And the user clicks 'KiwiSaver calculator link' on 'Calculator, fees & tools' page
		And the user lands on 'Westpac KiwiSaver Scheme Risk Profiler and Retirement Calculator' page
		And the user clicks 'Click here to get started button' on 'Westpac KiwiSaver Scheme Risk Profiler and Retirement Calculator' page
		And the user lands on 'KiwiSaver Retirement Calculator' page
	When the user enters '<Age>' as Current Age
		And the user selects '<Employment Status>' as Employment Status
		And the user enters '<Salary Or Wages>' as Salary Or Wages per year
		And the user selects '<Kiwisaver Contribution>' as Kiwisaver member contribution
		And the user enters '<Balance>' as Current KiwiSaver Balance
		And the user enters '<Contributions>' as Voluntary contributions and selects '<Frequency>' as Frequency
		And the user selects '<Risk Profile>' as Risk Profile
		And the user enters '<Savings Goal>' as Savings goal at retirement
	Then the user clicks 'View your KiwiSaver retirement projections' on 'KiwiSaver Retirement Calculator' page
		And the Estimated Kiwisaver should be displayed

Examples:
| Age | Employment Status | Salary Or Wages | Kiwisaver Contribution | Balance | Contributions | Frequency    | Risk Profile | Savings Goal | 
| 30  | Employed          | 82000           | 4%                     |         |               |              | Defensive    |              |     
                             
	
@regression
Scenario Outline: Verify Kiwisaver retirement calculations_Self and Non Employed Status
	Given the user lands on Westpac homepage
		And the user clicks 'KiwiSaver calculator link' on 'Calculator, fees & tools' page
		And the user lands on 'Westpac KiwiSaver Scheme Risk Profiler and Retirement Calculator' page
		And the user clicks 'Click here to get started button' on 'Westpac KiwiSaver Scheme Risk Profiler and Retirement Calculator' page
		And the user lands on 'KiwiSaver Retirement Calculator' page
	When the user enters '<Age>' as Current Age
		And the user selects '<Employment Status>' as Employment Status
		And the user enters '<Balance>' as Current KiwiSaver Balance
		And the user enters '<Contributions>' as Voluntary contributions and selects '<Frequency>' as Frequency
		And the user selects '<Risk Profile>' as Risk Profile
		And the user enters '<Savings Goal>' as Savings goal at retirement
	Then the user clicks 'View your KiwiSaver retirement projections' on 'KiwiSaver Retirement Calculator' page
		#And the Estimated Kiwisaver '<Kiwisaver Balance>' should be displayed

Examples:
| Age | Employment Status | Balance | Contributions | Frequency    | Risk Profile | Savings Goal |
| 45  | Self-Employed     | 100000  | 90            | Fortnightly  | Conservative | 290000       | 
| 55  | Not employed      | 140000  | 10            | Annually     | Balanced     | 200000       |   