
namespace Creatures
{
public abstract class Creature
{
    public abstract string Name { get; set; }
    public abstract int Strength { get; set; }
    public abstract int Wisdom { get; set; }
    public abstract int Charisma { get; set; }
    public abstract int Dexterity { get; set; }
    public abstract int Constitution { get; set; }
    public abstract int Intelligence { get; set; }
    public abstract int HitPoints { get; set; }
    public abstract int MaxHitPoints { get; set; }
    public abstract int ArmorClass { get; set; }
    public abstract int Initiative { get; set; }
    public abstract bool IsAlive { get; set; }
    public abstract int PartyIndex { get; set; }
    public abstract List<string> Spells { get; set; }
    public abstract bool IsHidden { get; set; }
    public abstract int StrengthModifier { get; set; }
    public abstract int WisdomModifier { get; set; }
    public abstract int CharismaModifier { get; set; }
    public abstract int DexterityModifier { get; set; }
    public abstract int ConstitutionModifier { get; set; }
    public abstract int IntelligenceModifier { get; set; }
    public abstract int InitiativeModifier { get; set; }
    public abstract  int ArmorClassModifier { get; set; }
    public abstract int HitPointsModifier { get; set; }
    public abstract int MaxHitPointsModifier { get; set; }

    public abstract bool IsMonster { get; set; }

    public abstract double challengeRating { get; set; }

     public abstract int getModifier( int abilityScore);

    public abstract int Level { get; set; } 

}

}
