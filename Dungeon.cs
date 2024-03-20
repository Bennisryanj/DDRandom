using Combat;
using Enemy;
using IniativeOrder;
using PartyGenerator;
using EnemyGenerator;
using Creatures;
using CreatureFactories;

namespace DDDungeon
{
    public class Dungeon
    {
        private List<Creature> enemies;
        private bool playerAlive;

        private int roomNumber;

        public Dungeon()
        {
            enemies = new List<Creature>();
            playerAlive = true;
        }


        public void Start()
        {
            Partygenerator  partyGenerator = new Partygenerator();             
            List<Creature> party = partyGenerator.generateParty();
            
            Console.WriteLine($"Welcome to the Dungeon!");
            System.Console.WriteLine("The Party is made up of the following characters:");
            foreach (Creature character in party)
            {
                System.Console.WriteLine($"{character.Name} has {character.HitPoints} hitpoints!");
            }
            
            while (party.Count > 0 && roomNumber < 10000)
            {

               EnemyFactory factory = new EnemyFactory();
               
               var gob = factory.CreateGoblin();

               gob.Name = "Goblin"; 

                int partyLevelAverage = getPartyLevelAverage(party);   
                EnemyGeneratorClass enemyGenerator = new EnemyGeneratorClass();
                List<Creature> enemies = enemyGenerator.generateEnemies(partyLevelAverage);
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
                        foreach (Creature character in party)
                        {
                            System.Console.WriteLine($"{character.Name} has {character.HitPoints} hitpoints!");
                        }
                    }
                    else if (roomNumber % 6 == 0 && party.Count > 0)
                    {
                        longRest(party);
                        foreach (Creature character in party)
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

        public void ecounter(List<Creature> party, List<Creature> enemies)
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

        public void shortRest(List<Creature> party)
        {
            foreach (Creature character in party)
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

        public void longRest(List<Creature> party)
        {
            foreach (Creature character in party)
            {
                if (character.IsAlive)
                {
                    character.HitPoints = character.MaxHitPoints;
                }
            }
        }

        public int getPartyLevelAverage(List<Creature> party)
        {
            int totalLevel = 0;
            foreach (Creature character in party)
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
