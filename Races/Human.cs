using PlayerRace;

namespace HumanRace 
{
    public class Human : Race
    {
        public override string RaceName { get; set; } = "Human";
        public override int StrengthModifier { get; set; } = 1;
        public override int DexterityModifier { get; set; } = 1;
        public override int IntelligenceModifier { get; set; } = 1;
        public override int WisdomModifier { get; set; } = 1;
        public override int ConstitutionModifier { get; set; } = 1;
        public override int CharismaModifier { get; set; } = 1;
        public override int HitPointsModifier { get; set; } = 1;
        public override int ArmorClassModifier { get; set; } = 1;
        public override int InitiativeModifier { get; set; } = 1;
        public override int MaxHitPointsModifier { get; set; } = 1;
    }
}