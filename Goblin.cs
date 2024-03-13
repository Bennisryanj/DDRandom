
using Enemy;

namespace EnemyTypeGoblin
{
    public class Goblin : Enemy.enemyClass
    {
        public override int CharismaModifier { get; set; } 
        public override int Initiative { get; set; }
        public override int ArmorClassModifier { get; set; }
        public override int Dexterity { get; set; } = 14;
        public override int PartyIndex { get; set; }
        public override List<string> Spells { get; set; } = [];
        public override int Charisma { get; set; } = 8;
        public override int Strength { get; set; } = 8;
        public override int MaxHitPointsModifier { get; set; }
        public override int InitiativeModifier { get; set; }
        public override int HitPointsModifier { get; set; }
        public override int Intelligence { get; set; } = 10;
        public override int WisdomModifier { get; set; }
        public override string Name { get; set; } 
        public override int HitPoints { get; set; } = 7;
        public override int StrengthModifier { get; set; } 
        public override int MaxHitPoints { get; set; } = 7;
        public override bool IsHidden { get; set; } = false;
        public override int DexterityModifier { get; set; }
        public override int Wisdom { get; set; } = 8;
        public override int Constitution { get; set; } = 14;
        public override int ConstitutionModifier { get; set; }
        public override int ArmorClass { get; set; } = 11;
        public override int IntelligenceModifier { get; set; }

        public override bool IsAlive { get; set; } = true;

        public override double challengeRating { get; set; } = 0.25;

        public override int getModifier(int abilityScore)
        {
            return (abilityScore - 10) / 2;
        }

        public string nameGoblin()
            {
                Random rnd = new Random();
                int name = rnd.Next(1, 4);
                List<string> goblinNames = new List<string> {"Gobbo", "Gob", "Goblin", "Gobgob", "Gobgoblin"};
                return goblinNames[name];
            }
    }   

}