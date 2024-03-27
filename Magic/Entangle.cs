namespace magic
{

    public class Entangle : Spell
    {
        public Entangle()
        {
            Random rnd = new Random();
            Damage = rnd.Next(1, 10);
            DamageType = "nature";
            Name = "Entangle";
        }
    }
}