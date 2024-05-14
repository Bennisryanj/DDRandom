using Die; 

namespace Items
{

    public class Crossbow : Weapon
    {


        private Dice diceroll;

       
        
        public override string Name { get; set; } = "Crossbow";

        public override int Value { get; set; } = 50;

        public override string Description { get; set; } = "A crossbow";

        public new  int DamageModifier {get; set;} = 0;

        public new  int Damage() { diceroll = new Dice();
            return  diceroll.rollAd8(); } 

    }
    
    }