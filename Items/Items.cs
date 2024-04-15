namespace Items
{

    public abstract class Item
    {

        public abstract string Name { get; set; }

        public abstract int Value { get; set; }

        public abstract string Description { get; set; }

        public abstract bool IsConsumable { get; set; }

        public abstract bool IsEquippable { get; set; }

    }
}
