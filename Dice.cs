namespace Die 
{
    public class Dice
    {

        public int rollAd4()
        {
            Random rnd = new Random();
            return rnd.Next(1,5);
        }

        public int rollAd6()
        {
            Random rnd = new Random();
            return rnd.Next(1,7);
        }

        public int rollAd8()
        {
            Random rnd = new Random();
            return rnd.Next(1,9);
        }

        public  int rollAd10()
        {
            Random rnd = new Random();
            return rnd.Next(1,10);
        }

        
        public int rollAd12()
        {
            Random rnd = new Random();
            return rnd.Next(1,13);
        }

        public int rollAd20()
        {
            Random rnd = new Random();
            return rnd.Next(1,21);
        }
    }


}