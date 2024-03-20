using System;
using Characterclass;
using magic;
using Creatures;
using PlayerRace;
using System.Dynamic;

namespace Creatures
{
    public class Wizard : Creature
    {
         public override int getModifier(int abilityScore)
        {
            return (abilityScore - 10) / 2;
        }

        public override List<string> Spells { get; set; } = new List<string> { "Firebolt", "Magic Missile", "Lightning Bolt" };
        public override string Name { get; set; } = "Wizard";
        public override int Strength { get; set; } = 10;
        public override int Dexterity { get; set; } = 10;
        public override int Intelligence { get; set; } = 10;
        public override int Wisdom { get; set; } = 10;
        public override int Constitution { get; set; } = 10;
        public override int Charisma { get; set; } = 10;

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
        public int SpellSlots { get; set; } = 2;
        public int SpellSlotsUsed { get; set; } = 0;
        public int SpellSaveDC { get; set; } = 10;

       


    }
}

