using System;
using System.Dynamic;
using System.Security.Cryptography;
using CharacterClass;
using Microsoft.VisualBasic;

namespace Character
{
    public class Character1
    {
        // Add properties, methods, and fields here

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }

        public int Intelligence { get; set; }
        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }
        public bool IsMonster { get; set; }
        public int Initiative { get; set; }
        public bool IsAlive { get; set; } = true;

        public int PartyIndex { get; set; }

        public List<string> Spells { get; set; }

        public bool IsHidden { get; set; } = false;




        // Need to add properties for the following:
        // Strength Modifier 
        // Wisdom Modifier
        // Charisma Modifier
        // Dexterity Modifier
        // Constitution Modifier


        public Character1(string name, int strength, int wisdom, int charisma, int dexterity, int constitution, int intelligence, int hitPoints, int armorClass, bool isMonster, int initiative = 0, bool isAlive = true, int partyIndex = 0) 
        {
            Name = name;
            Strength = strength;
            Wisdom = wisdom;
            Charisma = charisma;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            HitPoints = hitPoints;
            ArmorClass = armorClass;
            IsMonster = isMonster;
            Initiative = initiative;
            IsAlive = isAlive;
            PartyIndex = partyIndex;
        }

        //Wizard 
        public Character1( string name, int strength, int wisdom, int charisma, int dexterity, int constitution, int intelligence, int hitPoints, int armorClass, bool isMonster, int initiative = 0, bool isAlive = true, int partyIndex = 0, List<string> spells = null)
        {
            Name = name;
            Strength = strength;
            Wisdom = wisdom;
            Charisma = charisma;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            HitPoints = hitPoints;
            ArmorClass = armorClass;
            IsMonster = isMonster;
            Initiative = initiative;
            IsAlive = isAlive;
            PartyIndex = partyIndex;
            Spells = spells;
        }

        //Rogue
        public Character1(string name, int strength, int wisdom, int charisma, int dexterity, int constitution, int hitPoints, int armorClass, bool isMonster, int initiative = 0, bool isAlive = true, int partyIndex = 0, bool isHidden = false)
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
            IsHidden = isHidden;
        }

        //Fighter


               
        public void Die( bool isMonster, string name, int partyindex, List<Character1> party, List<Character1> enemies, List<Character1> iniativeOrder)
        {
            if (isMonster)
            {
                enemies[partyindex].IsAlive = false;
                Console.WriteLine($"{enemies[partyindex].Name} has been defeated!");
                enemies.Remove(enemies[partyindex]);
                iniativeOrder.Remove(enemies[partyindex]);
                
            }
            else
            {
                party[partyindex].IsAlive = false;
                Console.WriteLine($"{party[partyindex].Name} has been defeated!");
                party.Remove(party[partyindex]);
                iniativeOrder.Remove(party[partyindex]);

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

        public int getModifier(int abilityScore)
        {
            return (abilityScore - 10) / 2;
        }

        // public static implicit operator List<object>(Character1 v)
        // {
        //     throw new NotImplementedException();
        // }
    }
}