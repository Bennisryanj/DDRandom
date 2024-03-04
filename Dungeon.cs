using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Character;
using Combat;
using IniativeOrder;

namespace DDDungeon
{
    public class Dungeon
    {
        private List<Character1> enemies;
        private bool playerAlive;

        public Dungeon()
        {
            enemies = new List<Character1>();
            playerAlive = true;
        }


        public void Start()
        {
            string[] playerNames = { "Player1", "Player2", "Player3" };
            int randomIndex = new Random().Next(0, playerNames.Length);

            Character1 player = new Character1(playerNames[randomIndex], 10, 10, 10, 10, 10, 10, 10, false, 0, true, 0);

            List<Character1> party = generateParty();
            List<Character1> enemies = GenerateEnemies();

            // set up the code so it will finish a room and then ask the player if they want to continue
            // if they do, generate a new room with new enemies, keeping the same party
            // if they don't, end the game
            Console.WriteLine($"Welcome to the Dungeon, {player.Name}!");
            Console.WriteLine("You are now in a room with a monster!");



            while(party.Count > 0 && enemies.Count > 0)
            {
                ecounter(party, enemies);
            }
            if (party.Count == 0)
            {
                Console.WriteLine("You have been defeated!");
            }
            else if (enemies.Count == 0)
            {
                Console.WriteLine("You have defeated the enemies!");
            }
        }


        public List<Character1> generateParty()
        {
            List<Character1> party = new List<Character1>();
            string[] playerClasses = { "Wizard", "Fighter", "Rougue","Druid" };
            for (int i = 0; i < 3; i++)
            {
                //checks if wizard is in the party
                if (i == 0)
                {
                    Wizard playerWizard = new Wizard();
                    Character1 player = new Character1(playerWizard.ClassName, playerWizard.Strength, playerWizard.Wisdom, playerWizard.Charisma, playerWizard.Dexterity,
                     playerWizard.Constitution,playerWizard.Intelligence, 100, 10, false, 0, true, i, playerWizard.Spells);
                    party.Add(player);
                }
                if (i == 1)
                {
                    Rouge playerRougue = new Rouge();
                    Character1 player = new Character1(playerRougue.ClassName, playerRougue.Strength, playerRougue.Wisdom, playerRougue.Charisma, playerRougue.Dexterity,
                     playerRougue.Constitution, 100, 10, false, 0, true, i);
                    party.Add(player);
                }
                if (i == 2 )
                {
                    Fighter playerFighter = new Fighter();
                    Character1 player = new Character1(playerFighter.ClassName, playerFighter.Strength, playerFighter.Wisdom, playerFighter.Charisma, playerFighter.Dexterity,
                     playerFighter.Constitution, 100, 10, false, 0, true, i);
                    party.Add(player);
                }
                if (i == 3)
                {
                    Druid playerDruid = new Druid();
                    Character1 player = new Character1(playerDruid.ClassName, playerDruid.Strength, playerDruid.Wisdom, playerDruid.Charisma, playerDruid.Dexterity,
                     playerDruid.Constitution, 100, 10, false, 0, true, i);
                    party.Add(player);
                }
                
            }
            return party;

        }

        public void ecounter(List<Character1> party, List<Character1> enemies)
        {
           
            Combat1 combat = new Combat1();
            IniativeOrder1 iniativeOrder = new IniativeOrder1();
            List<Character1> io = iniativeOrder.iniativeorder(party, enemies);
            System.Console.WriteLine("Order of initiative:");

            while (party.Count > 0 && enemies.Count > 0)
            {
                combat.Fight(party, enemies,io);
            } 

        }

        public List<Character1> GenerateEnemies()
        {
            string[] enemyNames = { "Little Baby Goblin", "Big Daddy Goblin", "Goblin King", "Goblin Queen", "Goblin Prince", "Goblin Princess", "Goblin Knight", "Goblin Wizard", "Goblin Sorcerer", "Goblin Cleric"};
            
            

            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                Character1 enemy = new Character1(enemyNames[i], 10, 10, 10, 10, 10, 1, 10, true, 0, true, i);
                enemies.Add(enemy);
                Console.WriteLine($"Generated enemy: {enemy.Name}");
                }
                if (i == 1)
                {
                Character1 enemy = new Character1(enemyNames[i], 10, 10, 10, 10, 10, 1, 10, true, 0, true, i);
                enemies.Add(enemy);
                Console.WriteLine($"Generated enemy: {enemy.Name}");

                }
                if (i == 2)
                {
                Character1 enemy = new Character1(enemyNames[i], 10, 10, 10, 10, 10, 1, 10, true, 0, true, i);
                enemies.Add(enemy);
                Console.WriteLine($"Generated enemy: {enemy.Name}");
                }
                if (i == 3)
                {
                Character1 enemy = new Character1(enemyNames[i], 10, 10, 10, 10, 10, 1, 10, true, 0, true, i);  
                enemies.Add(enemy);
                Console.WriteLine($"Generated enemy: {enemy.Name}");
                }
                if (i == 4)
                {
                Character1 enemy = new Character1(enemyNames[i], 10, 10, 10, 10, 10, 1, 10, true, 0, true, i);
                enemies.Add(enemy);
                Console.WriteLine($"Generated enemy: {enemy.Name}");
                }
            }
            return enemies;
        }
    }

}
