using Character;

namespace Attacks
{
    public abstract class Attack
    {
        public abstract int attackRoll {get; set;}
        public abstract int damageRoll {get; set;}

        public abstract int rollToAttack();
    }
}