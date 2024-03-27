using System.Runtime.CompilerServices;
using IniativeOrder;
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

        string message = "";

        public void Fight(List<Creature> party, List<Creature> enemies, List<Creature> iniativeOrder)
        {
            IniativeOrder1 IniativeOrder = new IniativeOrder1();

            List<Creature> test = IniativeOrder.iniativeorder(party, enemies);
            int attackRoll = 0;
            foreach (Creature character in test.ToList())
            {
                 if(party.Count == 0 || enemies.Count == 0)
                 {
                     break;
                 }
                attackRoll = getAttackRoll(character, attackRoll);
                int enemytarget = new Random().Next(0, enemies.Count);
                int partytarget = new Random().Next(0, party.Count);

                if (!character.IsMonster)
                {
                    playerAttack(character, party, enemies, attackRoll, enemytarget, partytarget);

                }
                else
                {
                    if (attackRoll > party[partytarget].ArmorClass && party[partytarget].IsAlive == true)
                    {
                        int enemyattack = attack.damage(character,party[partytarget],character.StrengthModifier);
                        message = $"{character.Name} attacks {party[partytarget].Name} for {enemyattack} damage!";
                        System.Console.WriteLine(message);
                        combatLogger.logAttack(message);
                    }
                }

                if (party[partytarget].HitPoints <= 0 && party[partytarget].IsAlive == true)
                {
                    playerdied(party, iniativeOrder, partytarget);

                }
                else if (enemies[enemytarget].HitPoints <= 0 && enemies[enemytarget].IsAlive == true)
                {
                    enemydied(enemies, iniativeOrder, enemytarget);
       
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
             if (character.Name == "Wizard" || character.Name == "Cleric" || character.Name == "Sorcerer" || character.Name == "Warlock"  || character.Name == "Druid")
                {
                    attackRoll =  spell.rollToAttack() + character.IntelligenceModifier;
                }
                else
                {
                     attackRoll = attack.rollToAttack() + character.StrengthModifier;
                }
                return attackRoll;
        }

        public void playerAttack(Creature character, List<Creature> party, List<Creature> enemies, int attackRoll, int enemytarget, int partytarget)
        {
            if (character.Name == "Wizard" || character.Name == "Cleric" || character.Name == "Sorcerer" || character.Name == "Warlock" || character.Name == "Druid")
                    {
                          int spellcount = character.Spells.Count;
                          int spellindex = new Random().Next(0, spellcount);

                        if (character.Name == "Druid" && party[partytarget].IsAlive == true && party[partytarget].IsMonster == false && spellindex == 0)
                        {
                          
                            int heal = spell.heal(character, party[partytarget], character.Spells[0]);
                            message = $"The {character.creatureRace.RaceName} {character.Name} heals {party[partytarget].Name} for {heal} hitpoints!";
                            System.Console.WriteLine(message);
                            combatLogger.logAttack(message);
                        } else if (attackRoll > enemies[enemytarget].ArmorClass && enemies[enemytarget].IsAlive == true )
                        {
                            int damage = spell.damage(character,enemies[enemytarget],character.Spells[spellindex]);
                            string spellname = character.Spells[spellindex];
                            message = $"The {character.creatureRace.RaceName} {character.Name} casts {spellname} on {enemies[enemytarget].Name} for {damage} damage!";
                            System.Console.WriteLine(message);
                            combatLogger.logAttack(message);
                        }
                    }
                    else
                    {
                        if (attackRoll > enemies[enemytarget].ArmorClass && enemies[enemytarget].IsAlive == true)
                        {
                             int physicaldamage = attack.damage(character,enemies[enemytarget], character.StrengthModifier);
                             message = $"The {character.creatureRace.RaceName} {character.Name} attacks {enemies[enemytarget].Name} for {physicaldamage} damage!";
                                System.Console.WriteLine(message);  
                                combatLogger.logAttack(message);
                        }
                    }
        }

    }
}
