using System;
using Creatures;
using PlayerRace;
using Items;

namespace Creatures
{

    public class Rouge : Creature
    {
        public Rouge() {}

        public Rouge(int strength, int dexterity, int intelligence, int wisdom, int constitution, int charisma, Race race, int partyIndex)
        {

            this.Name = "Rouge";
            this.IsAlive = true;
            this.PartyIndex = partyIndex;
            this.IsMonster = false;
            this.IsHidden = false;
            this.IsAlive = true;
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
            this.Wisdom = wisdom;
            this.Constitution = constitution;
            this.Charisma = charisma;
            this.StrengthModifier = getModifier(strength);
            this.DexterityModifier = getModifier(dexterity);
            this.IntelligenceModifier = getModifier(intelligence);
            this.WisdomModifier = getModifier(wisdom);
            this.ConstitutionModifier = getModifier(constitution);
            this.CharismaModifier = getModifier(charisma);
            this.Level = 1; 
            MaxHitPoints = 10 + race.HitPointsModifier;
            this.HitPoints = 10;
            this.Initiative = 0 + race.InitiativeModifier;
            this.ArmorClass = 10 + race.ArmorClassModifier;    
            this.creatureRace = race;
        }

        public override List<string> Spells { get; set; } = new List<string> { };
        public override string Name { get; set; } = "Rogue";
        public override int Strength { get; set; } 
        public override int Dexterity { get; set; } 
        public override int Intelligence { get; set; } 
        public override int Wisdom { get; set; } 
        public override int Constitution { get; set; } 
        public override int Charisma { get; set; } 

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
        public override int getModifier(int abilityScore)
        {
            return (abilityScore - 10) / 2;
        }
        public override int Level { get; set; } = 1;

        public override Race creatureRace { get; set;}

        public override Weapon weapon { get; set; } = new Dagger();

    public override bool IsCaster { get; set; } = false;    

    }

}



