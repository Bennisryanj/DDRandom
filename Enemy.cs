using Creatures; 

namespace Enemy
{
    public abstract class enemyClass : Creature
    {
        public abstract override string Name { get; set; }
        public  abstract override int Strength { get; set; }
        public  abstract override int Wisdom { get; set; }
        public abstract override int Charisma { get; set; }
        public  abstract override int Dexterity { get; set; }
        public abstract override int Constitution { get; set; }
        public abstract override int Intelligence { get; set; }
        public abstract override int HitPoints { get; set; }
        public abstract override int MaxHitPoints { get; set; }
        public abstract override int ArmorClass { get; set; }
        public abstract override int Initiative { get; set; }
        public abstract override bool IsAlive { get; set; }
        public abstract override int PartyIndex { get; set; }
        public abstract override List<string> Spells { get; set; }
        public abstract override bool IsHidden { get; set; } 
        public abstract override int StrengthModifier { get; set; }
        public abstract override int WisdomModifier { get; set; }
        public abstract override int CharismaModifier { get; set; }
        public  abstract override int DexterityModifier { get; set; }
        public  abstract override int ConstitutionModifier { get; set; }
        public abstract override int IntelligenceModifier { get; set; }
        public abstract override int InitiativeModifier { get; set; }
        public abstract override int ArmorClassModifier { get; set; }
        public abstract override int HitPointsModifier { get; set; }
        public abstract override int MaxHitPointsModifier { get; set; }

        public abstract double challengeRating { get; set; }


        public abstract int getModifier(int abilityScore);

        public override bool IsMonster { get; set;} = true;
    }


}