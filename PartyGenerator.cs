using System;
using DwarfRace;
using ElfRace;
using HlaflingRace;
using HumanRace;
using PlayerRace;
using Creatures;
using CreatureFactories;
using Items;
using Die;

namespace PartyGenerator
{
    class Partygenerator
    {
        static Human Human = new Human();
        static Elf Elf = new Elf();
        static Dwarf Dwarf = new Dwarf();
        static Halfling Halfling = new Halfling();
        Race[] playerRace = { Human, Elf, Dwarf, Halfling };

        Dice dice = new Dice();

        CreatureFactory creatureFactory = new CreatureFactory();
        public List<Creature> generateParty()
        {
            List<Creature> party = new List<Creature>();
            string[] playerClasses = { "Wizard", "Fighter", "Rougue", "Druid" };

            for (int i = 0; i <= 3; i++)
            {
                //checks if wizard is in the party
                if (i == 0)
                {
                    Creature player = generateWizard(i);
                    party.Add(player);
                }
                if (i == 1)
                {
                    Creature player = generateRougue(i);
                    party.Add(player);
                }
                if (i == 2)
                {
                    Creature player = generateFighter(i);
                    party.Add(player);
                }
                if (i == 3)
                {
                    Creature player = generateDruid(i);
                    party.Add(player);
                }

            }
            return party;

        }


        

        public Creature generateWizard(int partyIndex)
        {
            int raceIndex = new Random().Next(0, playerRace.Length);
            var wizard = creatureFactory.CreateWizard(dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), playerRace[raceIndex], partyIndex);

            // wizard.PartyIndex = partyIndex;
            return wizard;
        }

        public Creature generateRougue(int partyIndex)
        {
            int raceIndex = new Random().Next(0, playerRace.Length);
            var rouge = creatureFactory.CreateRouge();

            rouge.PartyIndex = partyIndex;
            rouge.Strength = dice.rollAd20();
            rouge.StrengthModifier = rouge.getModifier(rouge.Strength) + playerRace[raceIndex].StrengthModifier;
            rouge.Wisdom = dice.rollAd20();
            rouge.WisdomModifier = rouge.getModifier(rouge.Wisdom) + playerRace[raceIndex].WisdomModifier;;
            rouge.Charisma = dice.rollAd20();
            rouge.CharismaModifier = rouge.getModifier(rouge.Charisma) + playerRace[raceIndex].CharismaModifier;
            rouge.Dexterity = dice.rollAd20();
            rouge.DexterityModifier = rouge.getModifier(rouge.Dexterity) + playerRace[raceIndex].DexterityModifier;
            rouge.Constitution = dice.rollAd20();
            rouge.ConstitutionModifier = rouge.getModifier(rouge.Constitution) + playerRace[raceIndex].ConstitutionModifier;
            rouge.MaxHitPoints = rouge.MaxHitPoints + playerRace[raceIndex].HitPointsModifier;
            rouge.HitPoints = rouge.MaxHitPoints;
            rouge.ArmorClass = rouge.ArmorClass + playerRace[raceIndex].ArmorClassModifier;
            rouge.Initiative = rouge.Initiative + playerRace[raceIndex].InitiativeModifier;
            rouge.IsAlive = true;
            rouge.creatureRace = playerRace[raceIndex];
            rouge.weapon = new Dagger();

            return rouge;

        }

        public Creature generateFighter(int partyIndex)
        {
            int raceIndex = new Random().Next(0, playerRace.Length);
            var fighter = creatureFactory.CreateFighter();

            fighter.PartyIndex = partyIndex;
            fighter.Strength = dice.rollAd20();
            fighter.StrengthModifier = fighter.getModifier(fighter.Strength) + playerRace[raceIndex].StrengthModifier;
            fighter.Wisdom = dice.rollAd20();
            fighter.WisdomModifier = fighter.getModifier(fighter.Wisdom) + playerRace[raceIndex].WisdomModifier;
            fighter.Charisma = dice.rollAd20();
            fighter.CharismaModifier = fighter.getModifier(fighter.Charisma) + playerRace[raceIndex].CharismaModifier;
            fighter.Dexterity = dice.rollAd20();
            fighter.DexterityModifier = fighter.getModifier(fighter.Dexterity) + playerRace[raceIndex].DexterityModifier;
            fighter.Constitution = dice.rollAd20();
            fighter.ConstitutionModifier = fighter.getModifier(fighter.Constitution) + playerRace[raceIndex].ConstitutionModifier;
            fighter.MaxHitPoints = fighter.MaxHitPoints + playerRace[raceIndex].HitPointsModifier;
            fighter.HitPoints = fighter.MaxHitPoints;
            fighter.ArmorClass = fighter.ArmorClass + playerRace[raceIndex].ArmorClassModifier;
            fighter.Initiative = fighter.Initiative + playerRace[raceIndex].InitiativeModifier;
            fighter.IsAlive = true;
            fighter.creatureRace = playerRace[raceIndex];
            fighter.weapon = new LongSword();

            return fighter;
        }

        public Creature generateDruid(int partyIndex)
        {
            int raceIndex = new Random().Next(0, playerRace.Length);
            var druid = creatureFactory.CreateDruid();

            druid.PartyIndex = partyIndex;
            druid.Strength = dice.rollAd20();
            druid.StrengthModifier = druid.getModifier(druid.Strength) + playerRace[raceIndex].StrengthModifier;
            druid.Wisdom = dice.rollAd20();
            druid.WisdomModifier = druid.getModifier(druid.Wisdom) + playerRace[raceIndex].WisdomModifier;
            druid.Charisma = dice.rollAd20();
            druid.CharismaModifier = druid.getModifier(druid.Charisma) + playerRace[raceIndex].CharismaModifier;
            druid.Dexterity = dice.rollAd20();
            druid.DexterityModifier = druid.getModifier(druid.Dexterity) + playerRace[raceIndex].DexterityModifier;
            druid.Constitution = dice.rollAd20();
            druid.ConstitutionModifier = druid.getModifier(druid.Constitution) + playerRace[raceIndex].ConstitutionModifier;
            druid.MaxHitPoints = druid.MaxHitPoints + playerRace[raceIndex].HitPointsModifier;
            druid.HitPoints = druid.MaxHitPoints;
            druid.ArmorClass = druid.ArmorClass + playerRace[raceIndex].ArmorClassModifier;
            druid.Initiative = druid.Initiative + playerRace[raceIndex].InitiativeModifier;
            druid.IsAlive = true;
            druid.creatureRace = playerRace[raceIndex];

            return druid;
        
        }
    }

}