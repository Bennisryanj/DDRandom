namespace Items
{
    public class MagicalweaponsFacotry : IWeaponFactory
    {

        public IWeapon CreateWeapon()
        {
            return new Magicalweapons();
        }
        public IWeapon CreateWeapon(Weapon BaseWeapon)
        {
            return new Magicalweapons(BaseWeapon);
        }
    }

}