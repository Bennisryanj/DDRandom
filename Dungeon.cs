using Combat;
using Enemy;
using iniativeorder;
using PartyGenerator;
using EnemyGenerator;
using Creatures;
using CreatureFactories;
using partyManager;

namespace DDDungeon
{
    public class Dungeon
    {
        private List<Creature> enemies;
        private bool playerAlive;

        private int roomNumber;

        string message = "";
        CombatLogger combatLogger = new CombatLogger();

        PartyManager partyManager = new PartyManager();

        public Dungeon()
        {
            combatLogger.checkforExistingFile();
            enemies = new List<Creature>();
            playerAlive = true;
            combatLogger.logAttack("Dungeon has started!");

        }


        public void Start()
        {

            Partygenerator partyGenerator = new Partygenerator();
            List<Creature> party = partyGenerator.generateParty();

            foreach (Creature character in party)
            {
                character.printStats(character);
            }



            Console.WriteLine($"Welcome to the Dungeon!");

            System.Console.WriteLine("The Party is made up of the following characters:");

            foreach (Creature character in party)
            {
                message = $"{character.Name} has {character.HitPoints} hitpoints!";
                System.Console.WriteLine(message);
                combatLogger.logAttack(message);
            }

            while (party.Count > 0 && roomNumber < 10000)
            {

                int partyLevelAverage = partyManager.getPartyLevelAverage(party);
                EnemyGeneratorClass enemyGenerator = new EnemyGeneratorClass();
                List<Creature> enemies = enemyGenerator.generateEnemies(partyLevelAverage);

                foreach (Creature enemy in enemies)
                {
                    message = $"{enemy.Name} has {enemy.HitPoints} hitpoints!";
                    System.Console.WriteLine(message);
                    combatLogger.logAttack(message);
                }
                message = $"Room number: {roomNumber}";
                System.Console.WriteLine(message);
                combatLogger.logAttack(message);


                message = "You are now in a room with a monster!";
                Console.WriteLine(message);
                combatLogger.logAttack(message);
                ecounter(party, enemies);
                roomNumber += 1;
                if (roomNumber % 3 == 0 && roomNumber % 6 != 0 && party.Count > 0)
                {
                    partyManager.shortRest(party);
                    System.Console.WriteLine("You have taken a short rest!");
                    foreach (Creature character in party)
                    {
                        System.Console.WriteLine($"{character.Name} has {character.HitPoints} hitpoints!");
                    }
                }
                else if (roomNumber % 6 == 0 && party.Count > 0)
                {
                    partyManager.longRest(party);
                    foreach (Creature character in party)
                    {
                        character.Level = partyManager.Levelup(character.Level, character);
                    }
                    System.Console.WriteLine("THE PARTY HAS LEVELED UP!");
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
            message = $"you made it to Romm number: {roomNumber}!";
            System.Console.WriteLine(message);
            combatLogger.logAttack(message);



        }

        public void ecounter(List<Creature> party, List<Creature> enemies)
        {

            System.Console.WriteLine("Order of initiative:");
            IniativeOrder iniativeOrder = new IniativeOrder();
            List<Creature> iniativeorder = iniativeOrder.getInitativeOrder(party, enemies);
            Combat1 combat = new Combat1();

            combat.Fight(party, enemies, iniativeorder);


        }

      
    }

}
