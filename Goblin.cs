using Creatures;
using PlayerRace;

namespace Enemy
{
    public class Goblin : Creature
    {
        public override int MaxHitPoints { get; set; } = 7;
        public override int ArmorClass { get; set; } = 15;
        public override int DexterityModifier { get; set; } = 2;
        public override string Name { get; set; } 
        public override int Strength { get; set; } = 8;
        public override int StrengthModifier { get; set; } = -1;
        public override int ArmorClassModifier { get; set; } = 0;
        public override int Charisma { get; set; } = 8;
        public override int Constitution { get; set; } = 14;
        public override int InitiativeModifier { get; set; } = 0;
        public override int HitPoints { get; set; } = 7;
        public override bool IsHidden { get; set; } = false;
        public override int CharismaModifier { get; set; } = -1;
        public override int MaxHitPointsModifier { get; set; } = 0;
        public override int ConstitutionModifier { get; set; } = 2;
        public override int HitPointsModifier { get; set; } = 0;
        public override bool IsAlive { get; set; } = true;
        public override int Initiative { get; set; }
        public override int WisdomModifier { get; set; } = 0;
        public override int Dexterity { get; set; } = 14;
        public override bool IsMonster { get; set; } = true;
        public override List<string> Spells { get; set; }
        public override int Intelligence { get; set; } = 10;
        public override int Wisdom { get; set; } = 10;
        public override int IntelligenceModifier { get; set; } = 0;
        public override int PartyIndex { get; set; }

        public override double challengeRating { get; set; } = 0.25;
        public override int Level { get; set; } = 1;

        public override int getModifier(int abilityScore)
        {
            return (abilityScore - 10) / 2;
        }
        public override Race creatureRace { get; set; } 
        string[] goblinNames = new string[] { "Gob", "Gobbo", "Clnag", "Slang", "Slack", "Glang", "Blanf", "Glob", "Globbo", "Globb" };
        public string generateGoblinName()
        {
            
            Random random = new Random();
            int index = random.Next(goblinNames.Length);
            return goblinNames[index];
        }
    }

}