using CreatureFactories;
using Creatures;
using PlayerRace;

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

        public Wizard CreateWizard(int strength, int dexterity, int intelligence, int wisdom, int constitution, int charisma, Race race, int partyIndex)
        {
            throw new NotImplementedException();
        }

        public Rouge CreateRouge(int strength, int dexterity, int intelligence, int wisdom, int constitution, int charisma, Race race, int partyIndex)
        {
            throw new NotImplementedException();
        }

        public Fighter CreateFighter(int strength, int dexterity, int intelligence, int wisdom, int constitution, int charisma, Race race, int partyIndex)
        {
            throw new NotImplementedException();
        }

        public Druid CreateDruid( int strength, int dexterity, int intelligence, int wisdom, int constitution, int charisma, Race race, int partyIndex)
        {
            throw new NotImplementedException();
        }
    }

}
