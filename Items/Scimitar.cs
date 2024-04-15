using Die;

namespace Items
{

    public class Scimitar : Weapon
    {

        private Dice diceroll;

      


        public override string Name { get; set; } = "Scimitar";

        public override int Value { get; set; } = 100;

        public override string Description { get; set; } = "Scimitar";

        public override int Damage() 
        {
            diceroll = new Dice();
           return  diceroll.rollAd6();
        }

        public override int DamageModifier { get; set; } = 0;


    }

}