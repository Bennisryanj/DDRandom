namespace Items
{
    public class BaseWeaponFactory : IWeaponFactory
    {
        public IWeapon CreateWeapon()
        {
            return new Weapon();
        }
        public IWeapon CreateWeapon(Weapon BaseWeapon)
        {
            return new Weapon(BaseWeapon);
        }
    }


}