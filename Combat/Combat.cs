using System.Runtime.CompilerServices;
using Character;
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


        public void Fight(List<Character1> party, List<enemyClass> enemies, List<Creature> iniativeOrder)
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

                SpellAttack spell = new SpellAttack();
                PyshicalAttack attack = new PyshicalAttack();

                
                if (character.Name == "Wizard" || character.Name == "Cleric" || character.Name == "Sorcerer" || character.Name == "Warlock"  || character.Name == "Druid")
                {
                    attackRoll =  spell.rollToAttack() + character.Intelligence;
                }
                else
                {
                     attackRoll = attack.rollToAttack() + character.Strength;
                }
                int enemytarget = new Random().Next(0, enemies.Count);
                int partytarget = new Random().Next(0, party.Count);

                if (!character.IsMonster)
                {
                    if (character.Name == "Wizard" || character.Name == "Cleric" || character.Name == "Sorcerer" || character.Name == "Warlock" || character.Name == "Druid")
                    {
                        if (attackRoll > enemies[enemytarget].ArmorClass && enemies[enemytarget].IsAlive == true)
                        {
                            int damage = spell.damage(character,enemies[enemytarget],character.Spells[0]);
                            string spellname = character.Spells[0];
                            System.Console.WriteLine($"The {character.Name} casts {spellname} on {enemies[enemytarget].Name} for {damage} damage!");
                        }
                    }
                    else
                    {
                        if (attackRoll > enemies[enemytarget].ArmorClass && enemies[enemytarget].IsAlive == true)
                        {
                             int physicaldamage = attack.damage(character,enemies[enemytarget], character.Strength);
                            System.Console.WriteLine($"{character.Name} attacks {enemies[enemytarget].Name} for {physicaldamage} damage!");
                        }
                    }

                }
                else
                {
                    if (attackRoll > party[partytarget].ArmorClass && party[partytarget].IsAlive == true)
                    {
                        int enemyattack = attack.damage(character,party[partytarget],character.Strength);
                        System.Console.WriteLine($"{character.Name} attacks {party[partytarget].Name} for {enemyattack} damage!");
                    }
                }

                if (party[partytarget].HitPoints <= 0 && party[partytarget].IsAlive == true)
                {
                    List<Creature> diedThisTurn = new List<Creature>() { party[partytarget] };

                    iniativeOrder.Remove(party[partytarget]);

                    foreach (Character1 character1 in diedThisTurn.ToList())
                    {
                        System.Console.WriteLine($"{character1.Name} has been defeated!");
                            party.Remove(character1);
                            character1.IsAlive = false;

                        
                        
                        
                    }
                }
                else if (enemies[enemytarget].HitPoints <= 0 && enemies[enemytarget].IsAlive == true)
                {
                    iniativeOrder.Remove(enemies[enemytarget]);
                    List<Creature> diedThisTurn = new List<Creature>() { enemies[enemytarget] };

                    foreach (enemyClass enemy in diedThisTurn.ToList())
                    {
                            System.Console.WriteLine($"{enemy.Name} has been defeated!");
                            enemies.Remove(enemy);
                            enemy.IsAlive = false;
                    }

                }

            }
        }

    }
}
