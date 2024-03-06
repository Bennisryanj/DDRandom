namespace PlayerRace 
{
public abstract class Race 
{
    public abstract string RaceName { get; set; }
    public abstract int StrengthModifier { get; set; }
    public abstract int DexterityModifier { get; set; }
    public abstract int IntelligenceModifier { get; set; }
    public abstract int WisdomModifier { get; set; }
    public abstract int ConstitutionModifier { get; set; }
    public abstract int CharismaModifier { get; set; }
    public abstract int HitPointsModifier { get; set; }
    public abstract int ArmorClassModifier { get; set; }
    public abstract int InitiativeModifier { get; set; }
    public abstract int MaxHitPointsModifier { get; set; }

}

}