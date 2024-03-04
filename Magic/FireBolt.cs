namespace magic
{
    public class FireBolt : Spell
    {
        public FireBolt()
        {
            Random rnd = new Random();
            Damage = rnd.Next(1, 10);
            DamageType = "fire";
            Name = "Fire Bolt";
        }
    }
}