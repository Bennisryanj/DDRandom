

namespace Items
{
    public class Magicalweapons : IWeapon
    {

        public Magicalweapons()
        {
            Name = "Magical Weapon";
            Value = 100;
            Description = "A Magical Weapon";
            DamageModifier = 10;
        }

        public Magicalweapons(Weapon baseWeapon)
        {
            Name = "Magical Weapon";
            Value = 100;
            Description = "A Magical Weapon";
            DamageModifier = 10;
            BaseWeapon = baseWeapon;
        }

        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public int DamageModifier { get; set; }

        public Weapon BaseWeapon { get; set; }

        public int Damage()
        {
            return 10 + DamageModifier;
        }
    }


}