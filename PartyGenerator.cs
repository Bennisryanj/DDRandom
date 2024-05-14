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
            var rouge = creatureFactory.CreateRouge(dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), playerRace[raceIndex], partyIndex);

            rouge.weapon = new Dagger();

            return rouge;

        }

        public Creature generateFighter(int partyIndex)
        {
            int raceIndex = new Random().Next(0, playerRace.Length);
            var fighter = creatureFactory.CreateFighter(dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), playerRace[raceIndex], partyIndex);

            fighter.weapon = new LongSword();

            return fighter;
        }

        public Creature generateDruid(int partyIndex)
        {
            int raceIndex = new Random().Next(0, playerRace.Length);
            var druid = creatureFactory.CreateDruid(dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), dice.rollAd20(), playerRace[raceIndex], partyIndex);

            return druid;
        
        }
    }

}