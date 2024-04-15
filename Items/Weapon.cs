namespace Items
{

    public abstract class Weapon : Item
    {

        public override abstract string Name { get; set; }

        public override abstract int Value { get; set; }

        public override abstract string Description { get; set; }

        public override bool IsConsumable { get; set; } = false;

        public override bool IsEquippable { get; set; } = true;

        public abstract int Damage();

        public abstract int DamageModifier { get; set; }

    

    }
}