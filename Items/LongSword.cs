using Die;

namespace Items
{

    public class LongSword : Weapon, IWeapon
    {


        Dice diceroll;

       


        public override string Name { get; set; } = "Long Sword";

        public override int Value { get; set; } = 100;

        public override string Description { get; set; } = "A long sword";

        public override int Damage() 
        {
             diceroll = new Dice();
           return diceroll.rollAd10();
        }

        public override int DamageModifier { get; set; } = 0;



    }

}