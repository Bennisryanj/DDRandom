using Items; 

namespace RandomEncounters
{
    public class Treasure 
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }

        public Weapon weapon { get; set; }



        public void createMagicItem(IWeaponFactory magicfactory)
        {

            var weapon = magicfactory.CreateWeapon();
            Name = weapon.Name;
            Value = weapon.Value;
            Description = weapon.Description;
        }

        public void createTreasure()
        {
            weapon = new Dagger();
            Name = weapon.Name;
            Value = weapon.Value;
            Description = weapon.Description;
        }


    }



}