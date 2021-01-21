Feature: A ship of size 2 sinks after taking 2 hits
	

@Hittest
Scenario: Hit test a ship on defender's board
	Given A ship of size 2 is placed vertically at (3,4) on a new game
	And Attacker hits at (3,4)
	And Attacker hits at (3,5)
	When checking game status
	Then the result should be game over