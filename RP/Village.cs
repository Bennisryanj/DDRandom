using System.Formats.Tar;

namespace roleplay
{
    public class Village
    {
        public string Name { get; set; }

        public int Population { get; set; }

        public void enterVillage()
        {
            System.Console.WriteLine("You have entered the village of " + Name);
            generateBuildings();
        }

        public void generateBuildings()
        {
            


        }




    }





}