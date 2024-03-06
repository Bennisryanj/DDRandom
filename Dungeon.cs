using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Character;
using Combat;
using IniativeOrder;
using PartyGenerator;

namespace DDDungeon
{
    public class Dungeon
    {
        private List<Character1> enemies;
        private bool playerAlive;

        private int roomNumber;

        public Dungeon()
        {
            enemies = new List<Character1>();
            playerAlive = true;
        }


        public void Start()
        {
            // string[] playerNames = { "Player1", "Player2", "Player3" };
            // int randomIndex = new Random().Next(0, playerNames.Length);
             Partygenerator  partyGenerator = new Partygenerator();
            List<Character1> party = partyGenerator.generateParty();
            

            // set up the code so it will finish a room and then ask the player if they want to continue
            // if they do, generate a new room with new enemies, keeping the same party
            // if they don't, end the game
            Console.WriteLine($"Welcome to the Dungeon!");
            Console.WriteLine("You are now in a room with a monster!");


            while (party.Count > 0)
            {
                List<Character1> enemies = GenerateEnemies();
                System.Console.WriteLine($"Room number: {roomNumber}");
                while (party.Count > 0 && enemies.Count > 0)
                {
                    ecounter(party, enemies);
                    roomNumber += 1;
                    if (roomNumber % 5 == 0 && roomNumber % 10 != 0)
                    {
                        shortRest(party);
                        System.Console.WriteLine("You have taken a short rest!");
                        foreach (Character1 character in party)
                        {
                            System.Console.WriteLine($"{character.Name} has {character.HitPoints} hitpoints!");
                        }
                    }
                    else if (roomNumber % 10 == 0)
                    {
                        longRest(party);
                    }
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
            System.Console.WriteLine($"you made it to Romm number: {roomNumber}!");

        }


       

        public void ecounter(List<Character1> party, List<Character1> enemies)
        {

            Combat1 combat = new Combat1();
            IniativeOrder1 iniativeOrder = new IniativeOrder1();
            List<Character1> io = iniativeOrder.iniativeorder(party, enemies);
            System.Console.WriteLine("Order of initiative:");

            while (party.Count > 0 && enemies.Count > 0)
            {
                combat.Fight(party, enemies, io);
            }

        }

        public List<Character1> GenerateEnemies()
        {
            string[] enemyNames = { "Little Baby Goblin", "Big Daddy Goblin", "Goblin King", "Goblin Queen", "Goblin Prince", "Goblin Princess", "Goblin Knight", "Goblin Wizard", "Goblin Sorcerer", "Goblin Cleric" };

            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    Character1 enemy = new Character1(enemyNames[i], 10, 10, 10, 10, 10, 1, 10,10, true, 0, true, i);
                    enemies.Add(enemy);
                    Console.WriteLine($"Generated enemy: {enemy.Name}");
                }
                if (i == 1)
                {
                    Character1 enemy = new Character1(enemyNames[i], 10, 10, 10, 10, 10, 1, 10,10, true, 0, true, i);
                    enemies.Add(enemy);
                    Console.WriteLine($"Generated enemy: {enemy.Name}");

                }
                if (i == 2)
                {
                    Character1 enemy = new Character1(enemyNames[i], 10, 10, 10, 10, 10, 1, 10,10, true, 0, true, i);
                    enemies.Add(enemy);
                    Console.WriteLine($"Generated enemy: {enemy.Name}");
                }
                if (i == 3)
                {
                    Character1 enemy = new Character1(enemyNames[i], 10, 10, 10, 10, 10, 1, 10,10, true, 0, true, i);
                    enemies.Add(enemy);
                    Console.WriteLine($"Generated enemy: {enemy.Name}");
                }
                if (i == 4)
                {
                    Character1 enemy = new Character1(enemyNames[i], 10, 10, 10, 10, 10, 1, 10,10, true, 0, true, i);
                    enemies.Add(enemy);
                    Console.WriteLine($"Generated enemy: {enemy.Name}");
                }
            }
            return enemies;
        }

        public void shortRest(List<Character1> party)
        {
            foreach (Character1 character in party)
            {
                if (character.IsAlive)
                {
                    if (character.HitPoints + 5 > character.MaxHitPoints)
                    {
                        character.HitPoints = character.MaxHitPoints;
                    }
                    else
                    {
                        character.HitPoints += 5;
                    }
                }
            }
        }

        public void longRest(List<Character1> party)
        {
            foreach (Character1 character in party)
            {
                if (character.IsAlive)
                {
                    character.HitPoints = character.MaxHitPoints;
                }
            }
        }
    }

}
