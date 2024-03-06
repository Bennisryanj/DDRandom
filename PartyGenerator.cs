using System;
using Character;
using Characterclass;
using DwarfRace;
using ElfRace;
using HlaflingRace;
using HumanRace;
using PlayerRace;

namespace PartyGenerator
{
    class Partygenerator
    {
        static Human Human = new Human();
        static Elf Elf = new Elf();
        static Dwarf Dwarf = new Dwarf();
        static Halfling Halfling = new Halfling();
        Race[] playerRace = { Human, Elf, Dwarf, Halfling };
        public List<Character1> generateParty()
        {
            List<Character1> party = new List<Character1>();
            string[] playerClasses = { "Wizard", "Fighter", "Rougue", "Druid" };

            for (int i = 0; i < 3; i++)
            {
                //checks if wizard is in the party
                if (i == 0)
                {
                    Character1 player = generateWizard(i);
                    party.Add(player);
                }
                if (i == 1)
                {
                    Character1 player = generateRougue(i);
                    party.Add(player);
                }
                if (i == 2)
                {
                    Character1 player = generateFighter(i);
                    party.Add(player);
                }
                if (i == 3)
                {
                    Character1 player = generateDruid(i);
                    party.Add(player);
                }

            }
            return party;

        }

        public Character1 generateWizard(int partyIndex)
        {
            Wizard playerWizard = new Wizard();
            int raceIndex = new Random().Next(0, playerRace.Length);
            Character1 player = new Character1(playerWizard.ClassName,
             playerWizard.Strength + playerRace[raceIndex].StrengthModifier,
             playerWizard.Wisdom + playerRace[raceIndex].WisdomModifier,
             playerWizard.Charisma + playerRace[raceIndex].CharismaModifier,
              playerWizard.Dexterity + playerRace[raceIndex].DexterityModifier,
             playerWizard.Constitution + playerRace[raceIndex].ConstitutionModifier,
              playerWizard.Intelligence + playerRace[raceIndex].IntelligenceModifier,
               100, 100, 10 + playerRace[raceIndex].DexterityModifier , false, 0, true, partyIndex, playerWizard.Spells);
            return player;
        }

        public Character1 generateRougue(int partyIndex)
        {
            Rouge playerRougue = new Rouge();
            int raceIndex = new Random().Next(0, playerRace.Length);
            Character1 player = new Character1(playerRougue.ClassName,
             playerRougue.Strength + playerRace[raceIndex].StrengthModifier,
             playerRougue.Wisdom + playerRace[raceIndex].WisdomModifier,
             playerRougue.Charisma + playerRace[raceIndex].CharismaModifier,
              playerRougue.Dexterity + playerRace[raceIndex].DexterityModifier,
             playerRougue.Constitution + playerRace[raceIndex].ConstitutionModifier,
              100, 100, 17, false, 0, true, partyIndex);
            return player;
        }

        public Character1 generateFighter(int partyIndex)
        {
            Fighter playerFighter = new Fighter();
            int raceIndex = new Random().Next(0, playerRace.Length);
            Character1 player = new Character1(playerFighter.ClassName,
             playerFighter.Strength + playerRace[raceIndex].StrengthModifier,
             playerFighter.Wisdom + playerRace[raceIndex].WisdomModifier,
             playerFighter.Charisma + playerRace[raceIndex].CharismaModifier,
              playerFighter.Dexterity + playerRace[raceIndex].DexterityModifier,
             playerFighter.Constitution + playerRace[raceIndex].ConstitutionModifier,
              100, 100, 17, false, 0, true, partyIndex);
            return player;
        }

        public Character1 generateDruid(int partyIndex)
        {
            Druid playerDruid = new Druid();
            int raceIndex = new Random().Next(0, playerRace.Length);
            Character1 player = new Character1(playerDruid.ClassName,
             playerDruid.Strength + playerRace[raceIndex].StrengthModifier,
             playerDruid.Wisdom + playerRace[raceIndex].WisdomModifier,
             playerDruid.Charisma + playerRace[raceIndex].CharismaModifier,
              playerDruid.Dexterity + playerRace[raceIndex].DexterityModifier,
             playerDruid.Constitution + playerRace[raceIndex].ConstitutionModifier,
              100, 100, 17, false, 0, true, partyIndex);
            return player;
        }
    }

}