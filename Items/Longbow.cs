using Die; 

namespace Items
{

    public class Longbow : Weapon, IWeapon
    {


        private Dice diceroll;

       
        
        public override string Name { get; set; } = "LongBow";

        public override int Value { get; set; } = 50;

        public override string Description { get; set; } = "A LongBow";

        public override int DamageModifier {get; set;} = 0;

        public  override int Damage() { diceroll = new Dice();
            return  diceroll.rollAd8(); } 

    }
    
    }