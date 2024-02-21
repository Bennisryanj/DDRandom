using Character;


namespace Combat
{
    public class Combat1
    {
        public void Fight(List<Character1> party, List<Character1> enemies)
        {
            rollInitiative(party, enemies);
            List<Character1> iniativeOrder = iniativeorder(party, enemies);



            foreach (Character1 character in iniativeOrder)
            {
                if (!character.IsMonster)
                {
                    int attackRoll = attack();
                    if (attackRoll > character.ArmorClass)
                    {
                        int randomIndex = new Random().Next(0, enemies.Count);
                        int damage = new Random().Next(1, 6);
                        enemies[randomIndex].HitPoints -= damage;
                        System.Console.WriteLine($"{character.Name} attacks {enemies[randomIndex].Name} for {damage} damage!");
                    }
                }
                else
                {
                    int attackRoll = attack();
                    if (attackRoll > character.ArmorClass)
                    {
                        int randomIndex = new Random().Next(0, party.Count);
                        int damage = new Random().Next(1, 6);
                        party[randomIndex].HitPoints -= damage;
                        System.Console.WriteLine($"{character.Name} attacks {party[randomIndex].Name} for {damage} damage!");
                        
                    }
                }

                if (character.HitPoints <= 0)
                {
                    if (character.IsMonster)
                    {
                        int enemyIndex = enemies.IndexOf(character);
                        character.Die(character.IsMonster, character.Name, enemyIndex, party, enemies);
                    }
                    else
                    {
                        int partyIndex = party.IndexOf(character);
                        character.Die(character.IsMonster, character.Name, partyIndex, party, enemies);
                    }
                }
                
            }

            
        }

        public void rollInitiative(List<Character1> party, List<Character1> enemies)
        {
            foreach (Character1 player in party)
            {
                player.Initiative = new Random().Next(1, 20);
            }

            foreach (Character1 enemy in enemies)
            {
                enemy.Initiative = new Random().Next(1, 20);
            }
        }

        public int attack()
        {
            return new Random().Next(1, 20);
        }

        public List<Character1> iniativeorder(List<Character1> party, List<Character1> enemies)
        {
            List<Character1> iniativeOrder = new List<Character1>();
            iniativeOrder.AddRange(party);
            iniativeOrder.AddRange(enemies);
            iniativeOrder.Sort((x, y) => x.Initiative.CompareTo(y.Initiative));

            return iniativeOrder;
        }


    }
}
