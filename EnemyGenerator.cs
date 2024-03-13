using Enemy;

namespace EnemyGenerator
{


    public class EnemyGeneratorClass
    {

        private double challengeRating {get; set;} = 0;

        public List<enemyClass> generateEnemies(int partyaverageLevel)
        {
            List<enemyClass> enemies = new List<enemyClass>();

            double calculatedChallengeRating = ((double)partyaverageLevel * .6635) -.305;

            while (challengeRating <= calculatedChallengeRating || (enemies.Count == 0))
            {
                enemies.Add(generateGoblin());
                challengeRating += enemies[enemies.Count - 1].challengeRating;
            }
            return enemies;
        }



        public Enemy.enemyClass generateGoblin()
        {
            EnemyTypeGoblin.Goblin goblin = new EnemyTypeGoblin.Goblin();
            goblin.Name = goblin.nameGoblin();
            return goblin;
        }
    }
}