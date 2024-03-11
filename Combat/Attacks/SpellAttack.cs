using Character;
using Attacks;
using magic;
using Creatures;

namespace SpellAttacks 
{
    public class SpellAttack : Attack
    {
        public override int attackRoll {get; set;}
        public override int damageRoll {get; set;}

        public override int rollToAttack()
        {
            Random rnd = new Random();
            attackRoll = rnd.Next(1, 20);
            return attackRoll;
        }


        public int damage(Creature attacker,Creature target, string spellName)
        {
            Random rnd = new Random();
            damageRoll = spellDamage(spellName) + attacker.Intelligence;
            target.HitPoints -= damageRoll;
            return damageRoll;
        }


        public int spellDamage(string spellName)
        {
            int spellDamage = 0;
            Spell spell = new Spell();
            if (spellName == "Firebolt")
            {
                FireBolt fireBolt = new FireBolt();
                 spellDamage = fireBolt.Damage;
            }
            else if (spellName == "MagicMissile")
            {
                MagicMissile magicMissile = new MagicMissile();
                spellDamage = magicMissile.Damage;
            }
            return spellDamage;
        }
    }




}