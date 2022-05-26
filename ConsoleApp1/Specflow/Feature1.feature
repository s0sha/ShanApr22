Feature: Feature1

Login to TurnUp portal, and test Time and Material Menu Option

@tag1
Scenario: Create TM records with valid details
	Given I have logged into turnup portal successfully.
	When I navigate to Time and Material page. I navigate to Employee page.
	When I create a new record with '<Code>'. I create a new reocrd with '<Name>'
	Then The record should be created successfully.

	
	 Examples:|Code| Name|
			  | M001    | Naaame |
			  | M000001 | Name   |
			 
