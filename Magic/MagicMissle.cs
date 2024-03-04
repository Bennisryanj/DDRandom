namespace magic
{

    public class MagicMissile : Spell
    {
        public MagicMissile()
        {
            Random rnd = new Random();
            Damage = rnd.Next(1, 4);
            DamageType = "force";
            Name = "Magic Missile";
        }
    }
}