using Enemy;
using Creatures;
using CreatureFactories;


namespace EnemyGenerator
{


    public class EnemyGeneratorClass
    {

        private double challengeRating {get; set;} = 0;

        public List<Creature> generateEnemies(int partyaverageLevel)
        {
            List<Creature> enemies = new List<Creature>();

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
            goblin.Name = goblin.generateGoblinName();            
            return goblin;
        }
    }
}