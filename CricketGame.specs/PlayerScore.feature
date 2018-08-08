Feature: PlayerScore
	In order to enjoy a game of cricket
	As a player
	I want to be told my score

@mytag
Scenario: Player score is zero when game starts

	When Player has started a game of cricket
	Then  the player score should be 0

Scenario: Player should be able to score runs
	Given Player has started a game of cricket
	When Player scores 4 runs
	Then the player score should be 4
Scenario: Player gets out
	Given Player has started a game of cricket
	Given Player scores 4 runs
	When Player gets out
