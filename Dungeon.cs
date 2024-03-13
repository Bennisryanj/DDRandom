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
            Partygenerator  partyGenerator = new Partygenerator();             
            List<Character1> party = partyGenerator.generateParty();
            
            Console.WriteLine($"Welcome to the Dungeon!");
            System.Console.WriteLine("The Party is made up of the following characters:");
            foreach (Character1 character in party)
            {
                System.Console.WriteLine($"{character.Name} has {character.HitPoints} hitpoints!");
            }
            
            while (party.Count > 0 && roomNumber < 10000)
            {

                int partyLevelAverage = getPartyLevelAverage(party);   
                EnemyGeneratorClass enemyGenerator = new EnemyGeneratorClass();
                List<enemyClass> enemies = enemyGenerator.generateEnemies(partyLevelAverage);
                System.Console.WriteLine($"Room number: {roomNumber}");
                while (party.Count > 0 && enemies.Count > 0)
                {
                    Console.WriteLine("You are now in a room with a monster!");
                    ecounter(party, enemies);
                    roomNumber += 1;
                    if (roomNumber % 3 == 0 && roomNumber % 6 != 0 && party.Count > 0)
                    {
                        shortRest(party);
                        System.Console.WriteLine("You have taken a short rest!");
                        foreach (Character1 character in party)
                        {
                            System.Console.WriteLine($"{character.Name} has {character.HitPoints} hitpoints!");
                        }
                    }
                    else if (roomNumber % 6 == 0 && party.Count > 0)
                    {
                        longRest(party);
                        foreach (Character1 character in party)
                        {
                            character.Level = Levelup(character.Level);
                        }
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

        public int getPartyLevelAverage(List<Character1> party)
        {
            int totalLevel = 0;
            foreach (Character1 character in party)
            {
                totalLevel += character.Level;
            }
            return totalLevel / party.Count;
        }

        public int Levelup(int level)
        {
            return level + 1;
        }
    }

}
