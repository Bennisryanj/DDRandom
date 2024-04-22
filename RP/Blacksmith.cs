using Items;

namespace roleplay
{
    public class Blacksmith
    {
        public string Name { get; set; }

        public List<Weapon> ItemsForSale { get; set; }

        public void enterBlacksmith()
        {
            System.Console.WriteLine("You have entered the Blacksmith shop of " + Name);
            generateIventory();
        }

        public void generateIventory()
        {
            
        }   





    }



}