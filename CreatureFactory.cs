using Enemy;
using Creatures;
using PlayerRace;

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

        public Wizard CreateWizard(int strength, int dexterity, int intelligence, int wisdom, int constitution, int charisma, Race race, int partyIndex)
        {
            return new Wizard(strength,dexterity, intelligence, wisdom, constitution,charisma, race, partyIndex);
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