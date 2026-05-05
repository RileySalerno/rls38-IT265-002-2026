Riley Salerno
# Changes from physical prototype:
- Narrowed down the challenges that the player can do to only three choices that give certain rewards because of their difficulty
- Changed the amount of cards that you get from landing on a gear tile
- Changed the amount of cards it takes to upgrade a piece of gear for each level
- Increased the amount of cards that the player can get
- Changed the battle system to include a chance to dodge attacks
- Increased the amount of tiles that are on the board
- Removed the spell upgrading mechanic and replaced it so you can only use a spell for the amount of them you have, but they still cost mana

# Game Name: Gearoseum
Genre: Strategy, Deck builder, 

# Game Elements: 
 The players will go around the board collecting gear, fighting enemies, and stealing gear from other players they run into by challenging them.

Player: 
- The number of players that can play the game at once 
- You need at least 2 players to play but the amount of total players can go up to 8

TECHNICAL SPECS 
Technical Form: 
- Basically there are 2D graphics (flat) and 3D graphics (form) 
- This game uses 3D graphics for the map, players, and models, use 3D graphics, While the Spells, gear, Potions, and tiles, use 2D graphics.


View: 
Camera view from which the player will experience the game 
 - The Camera view Is a birds eye view of where the player is, and as the player moves around the map, The camera follows. When the game progresses into a battle, The camera switches to a front 2D view of both characters like a fighting game or side scroller
Platform: 
- PC
Language: 
- I used the Language C# in unity

Device: 
- PC

# GAME PLAY 
- Gearoseum is a game where Players take turns going around a board collecting gear by Fighting monsters and stealing it from other players, Then, after a certain amount of rounds, Players will face off against each other in a tournament style best of 3 battle using the Spells, Armor, and Potions that they collect from their turns. The first phase of the Game is collecting gear. When traveling the board there are 3 types of tiles that a player can land on, a gear tile that allows The Player to draw three cards then pick two of the cards to add to their deck, A enemy tile then when landed on, will allow the player to battle an AI enemy such as a skeleton or zombie, if the player wins, Then the reward can be either a heath or mana potion, if the player loses then they have to discard a card. Finally there's the Challenge tile that allows the player who lands on it to challenge another player to a competition. One competition could be who collects the most cards in a certain amount of turns or defeats the most enemies in a certain amount of turns. After everyone's turn is up the game turns into the tournament style where two players are put against each other. The player starts by making their load out from the cards they have collected. Each player can choose two spells, and one gear piece to put into their load out and fight the other player. They then take turns choosing moves until one player dies. The player can only use spells for the amount of them they have in their hand, or they 

# Game Play Outline 
This outline will vary depending on the type of game. 
- Players open the Game and join a lobby
- Each player rolls a dice to move a certain number of spaces
- Player does the action of whatever tile they land on
- After a certain amount of turns go into tournament mode
- Players are put into brackets against, the more players, the larger the brackets
- Players build loadout based on their cards
- Players fight each other in turnbased combat
- Player who survives all rounds win while other players lose
- Game ends
- This is fun because it allows players to fight each other in however method they want by having their own custom set ups for spells and being able to sabotage each other while they are on the board, allowing the game to play over and over without feeling the same

# Key Features 
Key features are a list of game elements that are attractive to the player. 
- Building your own load out to fight players and enemies with
Different loadouts each time because of random cards given
Challenging other players to be able to steal their loot

# DESIGN DOCUMENT 

# Design Guidelines:
- This game is designed to be a prototype so there are very simple graphics and mechanics that can still make the game fun and engaging. There are also a limited number of different spells so as to not make the Game too complex.

# Game Design Definitions 
This section established the definition of the game play. Definitions should include how a player wins, loses, transitions between levels, and the main focus of the gameplay.
- Players win the game by Deafeating all of the other players in the tournament
- PLayers lose by Losing their match against a player in the tournament
- The Game transitions from the collection part to the tournament part after the selected rounds are up

# Game Flowchart 
The game flowchart provides a visual of how the different game elements and their properties interact. Game flowcharts should represent Objects, Properties, and Actions present in the game. Each of these items should have a number reference to where they exist within the game mechanics document. 
- Spells interact with the gear differently depending on if they are weak against the armor, for example Fire ball does less damage against water gear
- Health potions can heal the player in combat, forcing other players too think differently about what attacks they do
- The challenged chosen by a player can have different rewards depending on the difficulty


# Player Definitions 
A suggested list may include: 
- Stats: Players have 20 Health and 10 mana each
- Weapons: Players can use either a Sword or a Spell
- Armor: players can upgrade and use any armor they collect
- Actions: In a fight, PLayers can choose to roll a D6 for their sword, doing that amount of damage, or use one of their spells to do guaranteed damage. On the board players use a dice to roll to go a certain amount of spaces, then can either pick cards, fight an AI, or challenge other players.

# Player Properties: 
- Player interacts with the board by rolling a dice and then moving that amount of spaces on the board.
- Player obtains gear by Selecting two out of three cards drawn after landing on a Gear tile
- Players interact with enemies by using UI buttons to use spells and attacks against them

# Player Rewards:
- Health Potions: restore 5 health to a player
- Mana Potions: Restore 3 Mana points to player
- Start Tile: Completely restore Health of player
- Gear: Players can obtain spells and armor which are useful for combat against enemies and other players

# User Interface (UI) 
- While the player is on the board, The cards that they collect are constantly on screen to show what they have, When in combat each move has its own button with an icon of the attack that will be done (Sword, or a spell). At the top of the screen is a updating title with the current turn on it to show the player the turn. The player also has their characters mana and health bars in the bottom left show as a card with their chosen gladiator.
