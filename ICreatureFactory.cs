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
    Rouge CreateRouge();
    Fighter CreateFighter();
    Druid CreateDruid();
    //ICharacter CreatePlayerFactory();
}

}
