using Die; 

namespace Items
{

    public class Javlin : Weapon, IWeapon
    {
      
        private Dice diceroll;

       
        
        public override string Name { get; set; } = "Javlin";

        public override int Value { get; set; } = 50;

        public override string Description { get; set; } = "A javlin";

        public override int DamageModifier {get; set;} = 0;

        public  override int Damage() { diceroll = new Dice();
            return  diceroll.rollAd6(); }

    }
    
    
}