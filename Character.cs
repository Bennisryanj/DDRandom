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
        public int initiative { get; set; }

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
        
               
        public void Die( bool isMonster, string name)
        {

                if (isMonster = true)
                {
                 return;
                    
                }
                else
                {
                    Console.WriteLine($"{name} has been defeated!");
                }
        }

        public void Levelup()
        {
            // Add level up logic here
            // increase hit points by 10
            // increase armor class by 2
            // increase strength, wisdom, charisma, dexterity, and constitution by 1
            HitPoints += 10;
            ArmorClass += 2;
            Strength += 1;
            Wisdom += 1;
            Charisma += 1;
            Dexterity += 1;
            Constitution += 1;
        }
    }
}