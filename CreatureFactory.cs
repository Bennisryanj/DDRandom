using Enemy;
using Creatures;

namespace CreatureFactories
{

    public class CreatureFactory : ICreatureFactory
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
            return new Wizard();
        }

        public Rouge CreateRouge()
        {
            return new Rouge();
        }   

        public Fighter CreateFighter()
        {
            return new Fighter();
        }

        public Druid CreateDruid()
        {
            return new Druid();
        }
    }
}