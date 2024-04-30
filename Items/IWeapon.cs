using Items; 

namespace Items
{

public interface IWeapon
{
    public string Name { get; set; }
    public int Value { get; set; }
    public string Description { get; set; }

    public int DamageModifier {get; set;}

    public int Damage() { return 0; } 

}
}