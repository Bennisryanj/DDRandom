using Creatures;
using Enemy;
using PlayerRace;


namespace CreatureFactories
{

public interface ICreatureFactory
{
    Goblin CreateGoblin();
    BugBear CreateBugBear();
    Wizard CreateWizard(int strength, int dexterity, int intelligence, int wisdom, int constitution, int charisma, Race race, int partyIndex);
    Rouge CreateRouge(int strength, int dexterity, int intelligence, int wisdom, int constitution, int charisma, Race race, int partyIndex);
    Fighter CreateFighter(int strength, int dexterity, int intelligence, int wisdom, int constitution, int charisma, Race race, int partyIndex);
    Druid CreateDruid( int strength, int dexterity, int intelligence, int wisdom, int constitution, int charisma, Race race, int partyIndex);
    //ICharacter CreatePlayerFactory();
}

}
