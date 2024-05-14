using Items;

public interface IWeaponFactory
{
    IWeapon CreateWeapon();
    IWeapon CreateWeapon(Weapon BaseWeapon);
}