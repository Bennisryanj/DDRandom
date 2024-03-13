using Character;
using Attacks;
using Creatures;

namespace PhysicalAttacks
{
    class PyshicalAttack : Attack
    {
        public override int attackRoll { get; set; }
        public override int damageRoll { get; set; }
        public override int healRoll { get; set; }

        public override int rollToAttack()
        {
            Random rnd = new Random();
            attackRoll = rnd.Next(1, 20);
            return attackRoll;
        }
        public int damage(Creature attacker,Creature target, int Strength)
        {
            Random rnd = new Random();
            damageRoll = rnd.Next(1, 8) + Strength;
            target.HitPoints -= damageRoll;
            return damageRoll;
        }
    }

}