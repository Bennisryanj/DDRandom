using PlayerRace;

namespace ElfRace
{
    public class Elf:Race
    {
        public override string RaceName { get; set; } = "Elf";
        public override int StrengthModifier { get; set; } = 0;

        public override int DexterityModifier { get; set; } = 2;

        public override int IntelligenceModifier { get; set; } = 0;

        public override int WisdomModifier { get; set; } = 0;

        public override int ConstitutionModifier { get; set; } = 0;

        public override int CharismaModifier { get; set; } = 0;

        public override int HitPointsModifier { get; set; } = 0;

        public override int ArmorClassModifier { get; set; } = 0;

        public override int InitiativeModifier { get; set; } = 0;

        public override int MaxHitPointsModifier { get; set; } = 0;

    }
}