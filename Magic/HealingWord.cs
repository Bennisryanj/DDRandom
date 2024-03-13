namespace magic 
{

    public class HealingWord : Spell
    {
        public HealingWord()
        {
            Random rnd = new Random();
            Damage = rnd.Next(1, 4);
            DamageType = "healing";
            Name = "Healing Word";
        }
    }
}