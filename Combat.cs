using Character;


namespace Combat
{
    public class Combat1
    {
        public void Fight(Character1 character, Character1 enemy)
        {
            System.Console.WriteLine("test");
            while (character.HitPoints > 0 && enemy.HitPoints > 0)
            {
               
                character.Attack(enemy.ArmorClass, out bool success, out int damage);
                if (success)
                {
                    enemy.HitPoints -= damage;
                    System.Console.WriteLine($"{character.Name} attacks {enemy.Name} for " + damage + " damage!");
                }
                if (enemy.HitPoints > 0)
                {
                    enemy.Attack(character.ArmorClass, out bool success1, out int damage1);
                    if (success1)
                    {
                        character.HitPoints -= damage1;
                        System.Console.WriteLine($"{enemy.Name} attacks {character.Name} for " + damage1 + " damage!");
                    }
                }
            }

            if (character.HitPoints <= 0)
            {

                character.Die(character.HitPoints, character.IsMonster);
            }
            else
            {
                enemy.Die(enemy.HitPoints, enemy.IsMonster);
            }
        }
    }
}
