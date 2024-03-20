using System;
using System.Collections.Generic;
using Enemy;
using Creatures;

namespace IniativeOrder
{
    public class IniativeOrder1
    {

        public void rollInitiative(List<Creature> party, List<Creature> enemies)
        {
            Random rnd = new Random();
            foreach (Creature character in party)
            {
                character.Initiative = rnd.Next(1, 20) + character.getModifier(character.Dexterity);
            }
            foreach (Creature enemy in enemies)
            {
                enemy.Initiative = rnd.Next(1, 20) + enemy.getModifier(enemy.Dexterity);
            }
        }
        
        public List<Creature> iniativeorder(List<Creature> party, List<Creature> enemies)
        {
            List<Creature> iniativeOrder = new List<Creature>();
            List<Creature> temp = new List<Creature>();
            temp.AddRange(party);
            temp.AddRange(enemies);
            temp.Sort((x, y) => y.Initiative.CompareTo(x.Initiative));
            iniativeOrder.AddRange(temp);
            return iniativeOrder;
        }
    }
}
