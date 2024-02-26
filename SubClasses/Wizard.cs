using System;
using Character;
using CharacterClass;
using magic;

public class Wizard : CharacterClass1
{

    public List<string> Spells { get; set; } = new List<string> { "Fireball", "Magic Missile", "Lightning Bolt" };
    public override string ClassName { get; set;} = "Wizard";
    public override int Strength { get; set; } = 10;
    public override int Dexterity { get; set; } = 10;
    public override int Intelligence { get; set; } = 10;
    public override int Wisdom { get; set; } = 10;
    public override int Constitution { get; set; } = 10;
    public override int Charisma { get; set; } = 10;


}
