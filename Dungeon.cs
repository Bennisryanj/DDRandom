using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Character;
using Combat;

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

            Character1 player = new Character1(playerNames[randomIndex], 10, 10, 10, 10, 10, 10, 10, false);

          //  generateParty();
            Console.WriteLine($"Welcome to the Dungeon, {player.Name}!");
            Console.WriteLine("You are now in a room with a monster!");
            while (playerAlive)
            {
                ecounter(player);
                if (player.HitPoints <= 0)
                {
                    playerAlive = false;
                    Console.WriteLine("You have died!");
                }
                else
                {
                    Console.WriteLine("You have defeated the monster!");
                }
            }
        }


        public Character1[] generateParty()
        {
            Character1[] party = new Character1[4];
            string[] playerNames = { "Wizard", "Fighter", "Rougue","Druid" };
            for (int i = 0; i < 4; i++)
            {
                int randomIndex = new Random().Next(0, playerNames.Length);
                Character1 player = new Character1(playerNames[randomIndex], 10, 10, 10, 10, 10, 10, 10, false);
                party[i] = player;
                
            }
            return party;

        }

        public async void ecounter(Character1 character)
        {
           List<Character1> enemies = GenerateEnemies();

            Combat1 combat = new Combat1();

            foreach (Character1 enemy in enemies)
            {
                combat.Fight(character, enemy);
            }

        }

        public List<Character1> GenerateEnemies()
        {
            string[] enemyNames = { "Little Baby Goblin", "Big Daddy Goblin", "Goblin King", "Goblin Queen", "Goblin Prince", "Goblin Princess", "Goblin Knight", "Goblin Wizard", "Goblin Sorcerer", "Goblin Cleric"};
            
            

            for (int i = 0; i < 3; i++)
            {
                int randomIndex = new Random().Next(0, enemyNames.Length);
                Character1 enemy = new Character1(enemyNames[randomIndex], 10, 10, 10, 10, 10, 1, 10, true);
                enemies.Add(enemy);
                Console.WriteLine($"Generated enemy: {enemy.Name}");
            }
            return enemies;
        }
    }

}
