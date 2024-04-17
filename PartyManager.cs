using Creatures;

namespace partyManager
{
    public class PartyManager
    {

        public void shortRest(List<Creature> party)
        {
            foreach (Creature character in party)
            {
                if (character.IsAlive)
                {
                    if (character.HitPoints + 5 > character.MaxHitPoints)
                    {
                        character.HitPoints = character.MaxHitPoints;
                    }
                    else
                    {
                        character.HitPoints += 5;
                    }
                }
            }
        }

        public void longRest(List<Creature> party)
        {
            foreach (Creature character in party)
            {
                if (character.IsAlive)
                {
                    character.HitPoints = character.MaxHitPoints;
                }
            }
        }

        public int getPartyLevelAverage(List<Creature> party)
        {
            int totalLevel = 0;
            foreach (Creature character in party)
            {
                totalLevel += character.Level;
            }
            return totalLevel / party.Count;
        }

        public int Levelup(int level, Creature playerCharacter)
        {
            playerCharacter.ArmorClass += 1;
            playerCharacter.MaxHitPoints += 5;
            playerCharacter.HitPoints = playerCharacter.MaxHitPoints;
            if (playerCharacter.Name == "Wizard")
            {
                playerCharacter.Wisdom += 1;
                playerCharacter.WisdomModifier = playerCharacter.getModifier(playerCharacter.Wisdom);
                playerCharacter.Intelligence += 1;
                playerCharacter.IntelligenceModifier = playerCharacter.getModifier(playerCharacter.Intelligence);
            }
            if (playerCharacter.Name == "Fighter")
            {
                playerCharacter.Strength += 1;
                playerCharacter.StrengthModifier = playerCharacter.getModifier(playerCharacter.Strength);
                playerCharacter.Constitution += 1;
                playerCharacter.ConstitutionModifier = playerCharacter.getModifier(playerCharacter.Constitution);
            }
            if (playerCharacter.Name == "Rougue")
            {
                playerCharacter.Dexterity += 1;
                playerCharacter.DexterityModifier = playerCharacter.getModifier(playerCharacter.Dexterity);
                playerCharacter.Charisma += 1;
                playerCharacter.CharismaModifier = playerCharacter.getModifier(playerCharacter.Charisma);
            }

            return level + 1;
        }


    }
}