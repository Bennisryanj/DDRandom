namespace magic

{
    public class Shillelagh : Spell
    {
        public Shillelagh()
        {
            Random rnd = new Random();
            Damage = rnd.Next(1, 10);
            DamageType = "bludgeoning";
            Name = "Shillelagh";
        }
    }
}