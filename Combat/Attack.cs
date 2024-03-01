using Character;

namespace Attacks
{
    public class Attack
    {
        int attackRoll;
        int damageRoll;

        public int rollToAttack()
        {
            Random rnd = new Random();
            attackRoll = rnd.Next(1, 20);
            return attackRoll;
        }

        public int damage(Character1 character)
        {
            Random rnd = new Random();
            damageRoll = rnd.Next(1, 8);
            character.HitPoints -= damageRoll;
            return damageRoll;
        }



    }
}