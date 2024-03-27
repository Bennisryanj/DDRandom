using System;
using DwarfRace;
using ElfRace;
using HlaflingRace;
using HumanRace;
using PlayerRace;
using Creatures;
using CreatureFactories;

namespace PartyGenerator
{
    class Partygenerator
    {
        static Human Human = new Human();
        static Elf Elf = new Elf();
        static Dwarf Dwarf = new Dwarf();
        static Halfling Halfling = new Halfling();
        Race[] playerRace = { Human, Elf, Dwarf, Halfling };

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
            var wizard = creatureFactory.CreateWizard();

            wizard.PartyIndex = partyIndex;
            wizard.StrengthModifier = wizard.getModifier(wizard.Strength) + playerRace[raceIndex].StrengthModifier;
            wizard.WisdomModifier = wizard.getModifier(wizard.Wisdom)  + playerRace[raceIndex].WisdomModifier;
            wizard.Charisma = wizard.getModifier(wizard.Charisma) + playerRace[raceIndex].CharismaModifier;
            wizard.Dexterity = wizard.getModifier(wizard.Dexterity) + playerRace[raceIndex].DexterityModifier;
            wizard.Constitution = wizard.getModifier(wizard.Constitution) + playerRace[raceIndex].ConstitutionModifier;
            wizard.MaxHitPoints = wizard.MaxHitPoints + playerRace[raceIndex].HitPointsModifier;
            wizard.HitPoints = wizard.MaxHitPoints;
            wizard.ArmorClass = wizard.ArmorClass + playerRace[raceIndex].ArmorClassModifier;
            wizard.Initiative = wizard.Initiative + playerRace[raceIndex].InitiativeModifier;
            wizard.IsAlive = true;
            wizard.creatureRace = playerRace[raceIndex];
            
            return wizard;
        }

        public Creature generateRougue(int partyIndex)
        {
            int raceIndex = new Random().Next(0, playerRace.Length);
            var rouge = creatureFactory.CreateRouge();

            rouge.PartyIndex = partyIndex;
            rouge.Strength = rouge.Strength + playerRace[raceIndex].StrengthModifier;
            rouge.Wisdom = rouge.Wisdom + playerRace[raceIndex].WisdomModifier;
            rouge.Charisma = rouge.Charisma + playerRace[raceIndex].CharismaModifier;
            rouge.Dexterity = rouge.Dexterity + playerRace[raceIndex].DexterityModifier;
            rouge.Constitution = rouge.Constitution + playerRace[raceIndex].ConstitutionModifier;
            rouge.MaxHitPoints = rouge.MaxHitPoints + playerRace[raceIndex].HitPointsModifier;
            rouge.HitPoints = rouge.MaxHitPoints;
            rouge.ArmorClass = rouge.ArmorClass + playerRace[raceIndex].ArmorClassModifier;
            rouge.Initiative = rouge.Initiative + playerRace[raceIndex].InitiativeModifier;
            rouge.IsAlive = true;
            rouge.creatureRace = playerRace[raceIndex];

            return rouge;

        }

        public Creature generateFighter(int partyIndex)
        {
            int raceIndex = new Random().Next(0, playerRace.Length);
            var fighter = creatureFactory.CreateFighter();

            fighter.PartyIndex = partyIndex;
            fighter.Strength = fighter.Strength + playerRace[raceIndex].StrengthModifier;
            fighter.Wisdom = fighter.Wisdom + playerRace[raceIndex].WisdomModifier;
            fighter.Charisma = fighter.Charisma + playerRace[raceIndex].CharismaModifier;
            fighter.Dexterity = fighter.Dexterity + playerRace[raceIndex].DexterityModifier;
            fighter.Constitution = fighter.Constitution + playerRace[raceIndex].ConstitutionModifier;
            fighter.MaxHitPoints = fighter.MaxHitPoints + playerRace[raceIndex].HitPointsModifier;
            fighter.HitPoints = fighter.MaxHitPoints;
            fighter.ArmorClass = fighter.ArmorClass + playerRace[raceIndex].ArmorClassModifier;
            fighter.Initiative = fighter.Initiative + playerRace[raceIndex].InitiativeModifier;
            fighter.IsAlive = true;
            fighter.creatureRace = playerRace[raceIndex];

            return fighter;
        }

        public Creature generateDruid(int partyIndex)
        {
            int raceIndex = new Random().Next(0, playerRace.Length);
            var druid = creatureFactory.CreateDruid();

            druid.PartyIndex = partyIndex;
            druid.Strength = druid.Strength + playerRace[raceIndex].StrengthModifier;
            druid.Wisdom = druid.Wisdom + playerRace[raceIndex].WisdomModifier;
            druid.Charisma = druid.Charisma + playerRace[raceIndex].CharismaModifier;
            druid.Dexterity = druid.Dexterity + playerRace[raceIndex].DexterityModifier;
            druid.Constitution = druid.Constitution + playerRace[raceIndex].ConstitutionModifier;
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