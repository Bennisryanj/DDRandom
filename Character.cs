using System;
using System.Dynamic;
using System.Security.Cryptography;
using Characterclass;
using Microsoft.VisualBasic;
using Characterclass;
using Creatures;

namespace Character
{
    public class Character1 : Creature
    {
        // Add properties, methods, and fields here

        public override string Name { get; set; }
        public override int Strength { get; set; }
        public override int Wisdom { get; set; }
        public override int Charisma { get; set; }
        public override int Dexterity { get; set; }
        public override int Constitution { get; set; }
        public override int Intelligence { get; set; }
        public override int HitPoints { get; set; }
        public override int MaxHitPoints { get; set; }
        public override int ArmorClass { get; set; }
        public override bool IsMonster { get; set; } = false;
        public override int Initiative { get; set; }
        public override bool IsAlive { get; set; } = true;
        public override int PartyIndex { get; set; }
        public override List<string> Spells { get; set; }
        public override bool IsHidden { get; set; } = false;

        public override int WisdomModifier {get;set;} 
        public override int ArmorClassModifier { get; set; }
        public override int HitPointsModifier {get;set;}
        public override int CharismaModifier { get; set; }
        public override int StrengthModifier { get; set; }
        public override int IntelligenceModifier { get; set; }
        public override int DexterityModifier { get; set; }
        public override int InitiativeModifier { get; set; }
        public override int ConstitutionModifier { get; set; }
        public override int MaxHitPointsModifier { get; set; }

    

        public Character1(string name, int strength, int wisdom, int charisma, int dexterity, int constitution, int intelligence, int hitPoints, int maxHitPoints, int armorClass, bool isMonster, int initiative = 0, bool isAlive = true, int partyIndex = 0)
        {
            Name = name;
            Strength = strength;
            Wisdom = wisdom;
            Charisma = charisma;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            HitPoints = hitPoints;
            MaxHitPoints = maxHitPoints;
            ArmorClass = armorClass;
            IsMonster = isMonster;
            Initiative = initiative;
            IsAlive = isAlive;
            PartyIndex = partyIndex;
        }

        //Wizard 
        public Character1(string name, int strength, int wisdom, int charisma, int dexterity, int constitution, int intelligence, int hitPoints, int maxHitPoints, int armorClass, bool isMonster, int initiative = 0, bool isAlive = true, int partyIndex = 0, List<string> spells = null)
        {
            Name = name;
            Strength = strength;
            Wisdom = wisdom;
            Charisma = charisma;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            HitPoints = hitPoints;
            MaxHitPoints = maxHitPoints;
            ArmorClass = armorClass;
            IsMonster = isMonster;
            Initiative = initiative;
            IsAlive = isAlive;
            PartyIndex = partyIndex;
            Spells = spells;
        }

        //Rogue
        public Character1(string name, int strength, int wisdom, int charisma, int dexterity, int constitution, int hitPoints, int maxHitPoints, int armorClass, bool isMonster, int initiative = 0, bool isAlive = true, int partyIndex = 0, bool isHidden = false)
        {
            Name = name;
            Strength = strength;
            Wisdom = wisdom;
            Charisma = charisma;
            Dexterity = dexterity;
            Constitution = constitution;
            HitPoints = hitPoints;
            MaxHitPoints = maxHitPoints;
            ArmorClass = armorClass;
            IsMonster = isMonster;
            Initiative = initiative;
            IsAlive = isAlive;
            PartyIndex = partyIndex;
            IsHidden = isHidden;
        }

        //Fighter

        public void Die(bool isMonster, string name, int partyindex, List<Character1> party, List<Character1> enemies, List<Character1> iniativeOrder)
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
    }
}