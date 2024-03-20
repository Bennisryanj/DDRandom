using Creatures;
using Enemy;


namespace CreatureFactories
{

public interface ICreatureFactory
{
    Goblin CreateGoblin();
    BugBear CreateBugBear();
    Wizard CreateWizard();
    Rouge CreateRouge();
    Fighter CreateFighter();
    Druid CreateDruid();
    //ICharacter CreatePlayerFactory();
}

}
