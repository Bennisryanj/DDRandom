using System;
using System.Security.Cryptography;

namespace Character
{
    public  class Character1
    {
        // Add properties, methods, and fields here

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }
        public bool IsMonster { get; set; }

        // Need to add properties for the following:
        // Strength Modifier 
        // Wisdom Modifier
        // Charisma Modifier
        // Dexterity Modifier
        // Constitution Modifier


        public Character1(string name, int strength, int wisdom, int charisma, int dexterity, int constitution, int hitPoints, int armorClass, bool isMonster)
        {
            Name = name;
            Strength = strength;
            Wisdom = wisdom;
            Charisma = charisma;
            Dexterity = dexterity;
            Constitution = constitution;
            HitPoints = hitPoints;
            ArmorClass = armorClass;
            IsMonster = isMonster;
        }

        public void Attack(int enemyarmorclass, out bool success, out int damage)
        {
            // Add attack logic here
            // should be a random number between 1 and 20 + strength modifier for a melee attack
            // if the number is greater than the enemy's armor class, the attack is successful
            // if the attack is successful, the damage is 5 (for now)
            damage = 5;
            if (Strength > enemyarmorclass)
            {
                success = false;
            }
            else
            {
                success = true;
            }

        }
        
               
        public void Die(int hitPoints, bool isMonster)
        {
            if (hitPoints <= 0)
            {
                if (isMonster)
                {
                    Console.WriteLine("Enemy has been defeated!");  
                    
                }
                else
                {
                    Console.WriteLine("Character has been defeated!");
                }
            }
        }
    }
}