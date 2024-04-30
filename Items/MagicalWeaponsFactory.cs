namespace Items
{
    public class MagicalweaponsFacotry : IWeaponFactory
    {
        public IWeapon CreateWeapon()
        {
            return new Magicalweapons();
        }
    }

}