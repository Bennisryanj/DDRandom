namespace
Characterclass
{

    public abstract class CharacterClass
    {
        public abstract string ClassName { get; set; }
        public  abstract int Strength { get; set; }
        public  abstract int Dexterity { get; set; }
        public abstract int Intelligence { get; set; }
        public abstract int Wisdom { get; set; }
        public abstract int Constitution { get; set; }
        public abstract int Charisma { get; set; }
    }
}