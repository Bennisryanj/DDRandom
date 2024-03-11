using Character;
using Combat;
using Enemy;
using IniativeOrder;
using PartyGenerator;
using EnemyGenerator;
using Creatures;

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
                EnemyGeneratorClass enemyGenerator = new EnemyGeneratorClass();
                List<enemyClass> enemies = enemyGenerator.generateEnemies(roomNumber);
                System.Console.WriteLine($"Room number: {roomNumber}");
                while (party.Count > 0 && enemies.Count > 0)
                {
                    ecounter(party, enemies);
                    roomNumber += 1;
                    if (roomNumber % 3 == 0 && roomNumber % 6 != 0)
                    {
                        shortRest(party);
                        System.Console.WriteLine("You have taken a short rest!");
                        foreach (Character1 character in party)
                        {
                            System.Console.WriteLine($"{character.Name} has {character.HitPoints} hitpoints!");
                        }
                    }
                    else if (roomNumber % 6 == 0)
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

        public void ecounter(List<Character1> party, List<enemyClass> enemies)
        {

            Combat1 combat = new Combat1();
            IniativeOrder1 iniativeOrder = new IniativeOrder1();
            List<Creature> io = iniativeOrder.iniativeorder(party, enemies);
            System.Console.WriteLine("Order of initiative:");

            while (party.Count > 0 && enemies.Count > 0)
            {
                combat.Fight(party, enemies, io);
            }

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
