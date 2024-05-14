using Die; 

namespace Items
{

    public class Shortbow : Weapon, IWeapon
    {


        private Dice diceroll;

       
        
        public override string Name { get; set; } = "Shortbow";

        public override int Value { get; set; } = 50;

        public override string Description { get; set; } = "A Shortbow";

        public  int DamageModifier {get; set;} = 0;

        public   int Damage()
         { diceroll = new Dice();
            return  diceroll.rollAd8(); } 

    }
    
    }