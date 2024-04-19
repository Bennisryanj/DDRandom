using System;
using magic;
using PlayerRace;
using Items;

namespace Creatures

{
    public class Druid : Creature
    {

    public override List<string> Spells { get; set; } = new List<string> {"Healing Word","Entangle","Shillelagh"};
    public override string Name { get; set;} = "Druid";
    public override int Strength { get; set; } = 12;
    public override int Dexterity { get; set; } = 13;
    public override int Intelligence { get; set; } = 15;
    public override int Wisdom { get; set; } = 14;
    public override int Constitution { get; set; } = 10;
    public override int Charisma { get; set; } = 8;

    public override int HitPoints { get; set; } = 10;
    public override int MaxHitPoints { get; set; } = 10;
    public override int ArmorClass { get; set; } = 10;
    public override int Initiative { get; set; } = 0;
    public override bool IsAlive { get; set; } = true;
    public override int PartyIndex { get; set; } = 0;
    public override bool IsMonster { get; set; } = false;
    public override bool IsHidden { get; set; } = false;
    public override int StrengthModifier { get; set; }
    public override int WisdomModifier { get; set; }
    public override int CharismaModifier { get; set; }
    public override int DexterityModifier { get; set; }
    public override int ConstitutionModifier { get; set; }

    public override int IntelligenceModifier { get; set; }
    public override int InitiativeModifier { get; set; }
    public override int ArmorClassModifier { get; set; }
    public override int HitPointsModifier { get; set; }
    public override int MaxHitPointsModifier { get; set; }
    public override double challengeRating { get; set; }

    public override int Level { get; set; } = 1;

    public override int getModifier(int abilityScore)
    {
        return (abilityScore - 10) / 2;
    }
     public override Race creatureRace { get; set;}

     public override  Weapon weapon { get; set; }

        public override bool IsCaster { get; set; } = true;

    }

    
}
