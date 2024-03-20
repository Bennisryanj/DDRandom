using CreatureFactories;
using Creatures;

namespace Enemy
{

    public class EnemyFactory : ICreatureFactory
    {
        public Goblin CreateGoblin()
        {
            return new Goblin();
        }

        public BugBear CreateBugBear()
        {
            return new BugBear();
        }

        public Wizard CreateWizard()
        {
            throw new NotImplementedException();
        }

        public Rouge CreateRouge()
        {
            throw new NotImplementedException();
        }

        public Fighter CreateFighter()
        {
            throw new NotImplementedException();
        }

        public Druid CreateDruid()
        {
            throw new NotImplementedException();
        }
    }

}
