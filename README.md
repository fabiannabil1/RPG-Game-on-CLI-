# RPG Battle System in C#

## Introduction
This project is a simple turn-based RPG battle system implemented in C# using object-oriented programming principles. It features a player-controlled character and an enemy character with attributes such as health points (HP), mana points (MP), strength, and different attack types.

## Features
- **Player Character (Pemain)**
  - Basic attack that consumes mana.
  - Special skills: Fireball, Ice Blast, and Heal.
  - Displays character information.
- **Enemy Character (Musuh)**
  - Takes damage from player attacks.
  - Displays a message when defeated.
- **Battle System**
  - Turn-based combat where the player selects an action each round.
  - Enemy HP decreases based on the selected attack.
  - The game ends when the enemy's HP reaches zero.

## Technologies Used
- C#
- .NET Core
- Object-Oriented Programming (OOP)

## How to Run
1. Install .NET Core SDK if not already installed.
2. Compile and run the program using a C# compiler or an IDE such as Visual Studio.
3. Follow the on-screen prompts to control the battle.

## Gameplay
1. The player character, **Edwin**, faces off against an enemy, **Eka**.
2. The player chooses from the following actions:
   - **Basic Attack**: Deals normal damage and consumes mana.
   - **Fireball**: Deals double damage and consumes more mana.
   - **Ice Blast**: Deals triple damage, consumes mana, and slows the enemy.
   - **Heal**: Restores HP and MP.
3. The battle continues until the enemy's HP reaches zero, at which point the player wins.

## Code Structure
- **Namespace `Karakter`**
  - Interface `Syarat_Karakter`
  - Abstract class `Method`
  - Concrete class `Pemain`
- **Namespace `musuh`**
  - Interface `Syarat_Musuh`
  - Abstract class `Method`
  - Concrete class `Musuh`
- **Main Program (`Program.cs`)**
  - Initializes the player and enemy.
  - Runs the battle loop until the enemy is defeated.

## Future Improvements
- Add enemy AI that can attack the player.
- Implement different types of enemies with unique abilities.
- Enhance graphics using a game engine like Unity.
- Introduce multiple player characters with varied abilities.

## License
This project is open-source and can be modified or distributed freely.

