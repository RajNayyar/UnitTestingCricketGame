Feature: TwoPlayer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Cricket Game Has Started
	Given PlayerOne is playing and PlayerTwo is not
	Given PlayerOne scores 5 runs
	Given PlayerTwo scores 4 runs
	When PlayerOne gets out 
	And PlayerTwo gets out
	Then Declare the winner
	
