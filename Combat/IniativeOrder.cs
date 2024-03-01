using System;
using System.Collections.Generic;
using Character;

namespace IniativeOrder
{
    public class IniativeOrder1
    {

        public void rollInitiative(List<Character1> party, List<Character1> enemies)
        {
            Random rnd = new Random();
            foreach (Character1 character in party)
            {
                character.Initiative = rnd.Next(1, 20);
            }
            foreach (Character1 character in enemies)
            {
                character.Initiative = rnd.Next(1, 20);
            }
        }
        public List<Character1> iniativeorder(List<Character1> party, List<Character1> enemies)
        {
            List<Character1> iniativeOrder = new List<Character1>();
            List<Character1> temp = new List<Character1>();
            temp.AddRange(party);
            temp.AddRange(enemies);
            temp.Sort((x, y) => y.Initiative.CompareTo(x.Initiative));
            iniativeOrder.AddRange(temp);
            return iniativeOrder;
        }
    }
}
