Feature: TwoPlayer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Cricket Game Has Started and PlayerOne wins
	Given PlayerOne is playing and PlayerTwo is not
	Given PlayerOne scores 5 runs
	And PlayerOne gets out
	And  PlayerTwo is playing
	And PlayerTwo scores 4 runs
	When PlayerTwo gets out
	Then The winner is PlayerOne

Scenario: Cricket Game Has Started and PlayerTwo Wins
	Given PlayerOne is playing and PlayerTwo is not
	Given PlayerOne scores 4 runs
	And PlayerOne gets out
	And PlayerTwo is playing
	And PlayerTwo scores 5 runs
	When PlayerTwo gets out
	Then The winner is PlayerTwo

Scenario: Cricket Game Has Started and Its a tie
	Given PlayerOne is playing and PlayerTwo is not
	Given PlayerOne scores 5 runs
	And PlayerOne gets out
	And PlayerTwo is playing
	And PlayerTwo scores 5 runs
	When PlayerTwo gets out
	Then Its Tie
