using System.Runtime.CompilerServices;
using iniativeorder;
using Attacks;
using System.Collections;
using SpellAttacks;
using PhysicalAttacks;
using System.Security.Cryptography;
using Enemy;
using Creatures;


namespace Combat
{
    public class Combat1
    {
        CombatLogger combatLogger = new CombatLogger();
        SpellAttack spell = new SpellAttack();
        PyshicalAttack attack = new PyshicalAttack();

        string message = string.Empty;

        int attackRoll = 0;

        public void Fight(List<Creature> party, List<Creature> enemies, List<Creature> initativeOrder)
        {

            System.Console.WriteLine("The order of initiative is:");
            foreach (Creature character in initativeOrder.ToList())
            {
                Console.WriteLine($"{character.Name} with an initiative of {character.Initiative}");
            }

            while (party.Count > 0 && enemies.Count > 0)
            {
                foreach (Creature character in initativeOrder.ToList())
                {


                    attackRoll = getAttackRoll(character, attackRoll);
                    int enemytarget = new Random().Next(0, enemies.Count);
                    int partytarget = new Random().Next(0, party.Count);


                    if (!character.IsMonster && enemies[enemytarget].IsAlive == true && character.IsAlive == true)
                    {
                        playerAttack(character, party, enemies, attackRoll, enemytarget, partytarget);

                    }
                    else if (character.IsMonster && party[partytarget].IsAlive == true && character.IsAlive == true)
                    {
                        Enemyattack(character, party, attackRoll, partytarget, enemies);
                        Console.WriteLine($"{party[partytarget].Name} has {party[partytarget].HitPoints} hitpoints remaining!");

                    }

                    if (party[partytarget].HitPoints <= 0 && party[partytarget].IsAlive == true)
                    {
                        playerdied(party, initativeOrder, partytarget);
                        if (party.Count == 0)
                        {
                            System.Console.WriteLine("The enemies have defeated the party!");
                            break;
                        }

                    }
                    else if (enemies[enemytarget].HitPoints <= 0 && enemies[enemytarget].IsAlive == true && enemies.Count > 0)
                    {
                        enemydied(enemies, initativeOrder, enemytarget);
                        if (enemies.Count == 0)
                        {
                            System.Console.WriteLine("The party has defeated the enemies!");
                            break;
                        }

                    }

                }
            }
        }

        public void playerdied(List<Creature> party, List<Creature> iniativeOrder, int partytarget)
        {
            List<Creature> diedThisTurn = new List<Creature>() { party[partytarget] };

            iniativeOrder.Remove(party[partytarget]);

            foreach (Creature character1 in diedThisTurn.ToList())
            {
                message = $"{character1.Name} has been defeated!";
                System.Console.WriteLine(message);
                combatLogger.logAttack(message);
                party.Remove(character1);
                character1.IsAlive = false;

            }

        }

        public void enemydied(List<Creature> enemies, List<Creature> iniativeOrder, int enemytarget)
        {
            iniativeOrder.Remove(enemies[enemytarget]);
            List<Creature> diedThisTurn = new List<Creature>() { enemies[enemytarget] };

            foreach (Creature enemy in diedThisTurn.ToList())
            {
                message = $"{enemy.Name} has been defeated!";
                System.Console.WriteLine(message);
                combatLogger.logAttack(message);
                enemies.Remove(enemy);
                enemy.IsAlive = false;
            }
        }

        public int getAttackRoll(Creature character, int attackRoll)
        {
            if (character.Name == "Wizard" || character.Name == "Cleric" || character.Name == "Sorcerer" || character.Name == "Warlock" || character.Name == "Druid")
            {
                attackRoll = spell.rollToAttack() + character.IntelligenceModifier;
            }
            else
            {
                attackRoll = attack.rollToAttack() + character.StrengthModifier;
            }
            return attackRoll;
        }

        public void playerAttack(Creature character, List<Creature> party, List<Creature> enemies, int attackRoll, int enemytarget, int partytarget)
        {
            if (attackRoll <= enemies[enemytarget].ArmorClass)
            {
                System.Console.WriteLine($"The {character.creatureRace.RaceName} {character.Name} missed the attack");
            }
            else
            {
                if (character.Name == "Wizard" || character.Name == "Cleric" || character.Name == "Sorcerer" || character.Name == "Warlock" || character.Name == "Druid")
                {
                    magicUserAttack(character, party, enemies, attackRoll, enemytarget, partytarget);

                }
                else
                {
                    PyshicalAttack(character, enemies, enemytarget);
                }
            }

        }

        public void Enemyattack(Creature enemy, List<Creature> party, int attackRoll, int partytarget, List<Creature> enemies)
        {

            int enemyattack = 0;
            if (attackRoll > party[partytarget].ArmorClass && party[partytarget].IsAlive == true)
            {
                enemyattack = attack.damage(enemy, party[partytarget], enemy.StrengthModifier);
                message = $"{enemy.Name} attacks {party[partytarget].Name} for {enemyattack} damage!";
                System.Console.WriteLine(message);
                combatLogger.logAttack(message);

            }
            else
            {

                System.Console.WriteLine($"{enemy.Name} missed the attack!");

            }
            System.Console.WriteLine($"the Enemy rolled a {attackRoll} to attack! and did {enemyattack} damage!");
        }

        public void magicUserAttack(Creature character, List<Creature> party, List<Creature> enemies, int attackRoll, int enemytarget, int partytarget)
        {
            int spellcount = character.Spells.Count;
            int spellindex = new Random().Next(0, spellcount);

            if (character.Name == "Druid" && spellindex == 0)
            {
                HealingSpell(character, party, partytarget);

            }
            else if (attackRoll > enemies[enemytarget].ArmorClass)
            {
                Damagespell(character, enemies, enemytarget, spellindex);

            }
        }

        public void PyshicalAttack(Creature character, List<Creature> enemies, int enemytarget)
        {
            int physicaldamage = attack.damage(character, enemies[enemytarget], character.StrengthModifier);
            message = $"The {character.creatureRace.RaceName} {character.Name} attacks {enemies[enemytarget].Name} for {physicaldamage} damage!";
            System.Console.WriteLine(message);
            combatLogger.logAttack(message);
        }

        public void HealingSpell(Creature character, List<Creature> party, int partytarget)
        {
            int heal = spell.heal(character, party[partytarget], character.Spells[0]);
            message = $"The {character.creatureRace.RaceName} {character.Name} heals {party[partytarget].Name} for {heal} hitpoints!";
            System.Console.WriteLine(message);
            combatLogger.logAttack(message);

        }

        public void Damagespell(Creature character, List<Creature> enemies, int enemytarget, int spellindex)
        {
            int damage = spell.damage(character, enemies[enemytarget], character.Spells[spellindex]);
            string spellname = character.Spells[spellindex];
            message = $"The {character.creatureRace.RaceName} {character.Name} casts {spellname} on {enemies[enemytarget].Name} for {damage} damage!";
            System.Console.WriteLine(message);
            combatLogger.logAttack(message);

        }


    }
}
