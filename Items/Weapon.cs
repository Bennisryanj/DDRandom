namespace Items
{

    public  class Weapon : Item, IWeapon
    {
        public int DamageModifier { get; set; } = 0;

        public int Damage()
        {
            return DamageModifier;
        }

        public Weapon()
        {
            Name = "Weapon";
            Value = 100;
            Description = "A Weapon";
        }

        public Weapon(Weapon baseWeapon)
        {
            Name = baseWeapon.Name;
            Value = baseWeapon.Value;
            Description = baseWeapon.Description;
            DamageModifier = baseWeapon.DamageModifier;
        }

        public override  string Name { get; set; }

        public override  int Value { get; set; }

        public override  string Description { get; set; }

        public override bool IsConsumable { get; set; } = false;

        public override bool IsEquippable { get; set; } = true;

    

    }
}