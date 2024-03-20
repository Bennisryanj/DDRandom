namespace Enemy

{
    public class BugBear
    {
        public int hitPoints = 27;
        public static int armorClass = 16;
        public int attackBonus = 4;
        public  static int damage = 11;
        public int initiative = 2;
        public int challengeRating = 1;
        public static int strength = 15;
        public static int dexterity = 14;
        public static int constitution = 13;
        public static int intelligence = 8;
        public static int wisdom = 11;
        public static int charisma = 9;
        public int strengthModifier = (strength - 10) / 2;
        public int dexterityModifier = (dexterity - 10) / 2;
        public int constitutionModifier = (constitution - 10) / 2;
        public int intelligenceModifier = (intelligence - 10) / 2;
        public int wisdomModifier = (wisdom - 10) / 2;
        public int charismaModifier = (charisma - 10) / 2;
        public bool isHidden = false;
        public bool isAlive = true;
        public string name = "BugBear";
        public int partyIndex = 0;
        public bool isMonster = true;
        public int level = 1;

        public void Attack()
        {
            throw new NotImplementedException();
        }

    }
}

