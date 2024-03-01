using System.Runtime.CompilerServices;
using Character;
using IniativeOrder;
using Attacks;


namespace Combat
{
    public class Combat1
    {


        public void Fight(List<Character1> party, List<Character1> enemies, List<Character1> iniativeOrder)
        {

            IniativeOrder1 IniativeOrder = new IniativeOrder1();

            List<Character1> test = IniativeOrder.iniativeorder(party, enemies);

            foreach (Character1 character in test.ToList())
            {
                if(party.Count == 0 || enemies.Count == 0)
                {
                    break;
                }
                Attack attack = new Attack();
                int attackRoll = attack.rollToAttack();
                int enemytarget = new Random().Next(0, enemies.Count);
                int partytarget = new Random().Next(0, party.Count);

                if (!character.IsMonster)
                {
                    if (attackRoll > enemies[enemytarget].ArmorClass && enemies[enemytarget].IsAlive == true)
                    {
                        attack.damage(enemies[enemytarget]);
                        System.Console.WriteLine($"{character.Name} attacks {enemies[enemytarget].Name} for {attack.damage(enemies[enemytarget])} damage!");
                        
                    }
                }
                else
                {
                    if (attackRoll > party[partytarget].ArmorClass && party[partytarget].IsAlive == true)
                    {
                        attack.damage(party[partytarget]);
                        System.Console.WriteLine($"{character.Name} attacks {party[partytarget].Name} for {attack.damage(party[partytarget])} damage!");
                    }
                }

                if (party[partytarget].HitPoints <= 0 && party[partytarget].IsAlive == true)
                {
                    List<Character1> diedThisTurn = new List<Character1>() { party[partytarget] };

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
                    List<Character1> diedThisTurn = new List<Character1>() { enemies[enemytarget] };

                    foreach (Character1 character1 in diedThisTurn.ToList())
                    {
                            System.Console.WriteLine($"{character1.Name} has been defeated!");
                            enemies.Remove(character1);
                            character1.IsAlive = false;
                    }

                }

            }


        }

  
        public int spellAttack(int randomSpell)
        {


            if (randomSpell == 0)
            {
                return new Random().Next(1, 10);
            }
            else if (randomSpell == 1)
            {
                return new Random().Next(1, 6);
            }
            else if (randomSpell == 2)
            {
                return new Random().Next(1, 12);
            }
            else
            {
                return new Random().Next(1, 20);
            }
        }


    }
}
