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
        public int Initiative { get; set; }
        public bool IsAlive { get; set; } = true;

        public int PartyIndex { get; set; }

        // Need to add properties for the following:
        // Strength Modifier 
        // Wisdom Modifier
        // Charisma Modifier
        // Dexterity Modifier
        // Constitution Modifier


        public Character1(string name, int strength, int wisdom, int charisma, int dexterity, int constitution, int hitPoints, int armorClass, bool isMonster, int initiative = 0, bool isAlive = true, int partyIndex = 0) 
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
            Initiative = initiative;
            IsAlive = isAlive;
            PartyIndex = partyIndex;
        }

        public void Attack(int enemyarmorclass, out bool success, out int damage)
        {
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
        
               
        public void Die( bool isMonster, string name, int partyindex, List<Character1> party, List<Character1> enemies)
        {
            if (isMonster)
            {
                enemies[partyindex].IsAlive = false;
                Console.WriteLine($"{enemies[partyindex].Name} has been defeated!");
                enemies.Remove(enemies[partyindex]);
                
            }
            else
            {
                party[partyindex].IsAlive = false;
                Console.WriteLine($"{party[partyindex].Name} has been defeated!");
                party.Remove(party[partyindex]);

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