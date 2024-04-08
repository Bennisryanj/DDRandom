using System;
using System.Collections.Generic;
using Enemy;
using Creatures;

namespace iniativeorder
{
    public class IniativeOrder
    {

        public void rollInitiative(List<Creature> party, List<Creature> enemies)
        {
            Random rnd = new Random();
            foreach (Creature character in party)
            {
                character.Initiative = rnd.Next(1, 20) + character.getModifier(character.DexterityModifier);
            }
            foreach (Creature enemy in enemies)
            {
                enemy.Initiative = rnd.Next(1, 20) + enemy.getModifier(enemy.DexterityModifier);
            }
        }
        
        public List<Creature> setIniativeOrder(List<Creature> party, List<Creature> enemies)
        {
            List<Creature> iniativeOrder = new List<Creature>();
            List<Creature> comabatParticipants = new List<Creature>();
            comabatParticipants.AddRange(party);
            comabatParticipants.AddRange(enemies);
            comabatParticipants.Sort((x, y) => y.Initiative.CompareTo(x.Initiative));
            iniativeOrder.AddRange(comabatParticipants);
            return iniativeOrder;
        }

        
 public List<Creature> getInitativeOrder(List<Creature> party, List<Creature> enemies)
        {
            
            IniativeOrder IniativeOrder = new IniativeOrder();
            IniativeOrder.rollInitiative(party, enemies);
            List<Creature> initativeOrder = IniativeOrder.setIniativeOrder(party, enemies);
            return initativeOrder;
        }


    }
}
