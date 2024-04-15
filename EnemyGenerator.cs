using Enemy;
using Creatures;
using CreatureFactories;
using Items;


namespace EnemyGenerator
{


    public class EnemyGeneratorClass
    {

        private double challengeRating {get; set;} = 0;
        
        public List<Creature> enemies = new List<Creature>();

        public List<string>  usedEnemyNames = new List<string>();

        public List<Creature> generateEnemies(int partyaverageLevel)
        {
            
            double calculatedChallengeRating = ((double)partyaverageLevel * .9) -.305;

            while (challengeRating <= calculatedChallengeRating || (enemies.Count == 0))
            {
                enemies.Add(generateGoblin());
                challengeRating += enemies[enemies.Count - 1].challengeRating;
                
            }
            return enemies;
        }



        public Creature generateGoblin()
        {
            CreatureFactory creatureFactory = new CreatureFactory();

            var goblin = creatureFactory.CreateGoblin();
            goblin.weapon = new Scimitar();
            if (!usedEnemyNames.Contains(goblin.Name))
            {
                goblin.Name = goblin.generateGoblinName();
                usedEnemyNames.Add(goblin.Name);
            }
            else
            {
                while (usedEnemyNames.Contains(goblin.Name))
                {
                    goblin.Name = goblin.generateGoblinName();
                    usedEnemyNames.Add(goblin.Name);
                }
            }
            return goblin;

        }
    }
}