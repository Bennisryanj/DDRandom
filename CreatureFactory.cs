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

        public Rouge CreateRouge(int strength, int dexterity, int intelligence, int wisdom, int constitution, int charisma, Race race, int partyIndex)
        {
            return new Rouge(strength, dexterity, intelligence, wisdom, constitution, charisma, race, partyIndex);

        }   

        public Fighter CreateFighter( int strength, int dexterity, int intelligence, int wisdom, int constitution, int charisma,Race race, int partyIndex)
        {
            return new Fighter(strength, dexterity, intelligence, wisdom, constitution, charisma, race, partyIndex);

        }

        public Druid CreateDruid(int strength, int dexterity, int intelligence, int wisdom, int constitution, int Charisma, Race race, int partyIndex)
        {
            return new Druid(strength, dexterity, intelligence, wisdom, constitution, Charisma, race, partyIndex);

        }
    }
}