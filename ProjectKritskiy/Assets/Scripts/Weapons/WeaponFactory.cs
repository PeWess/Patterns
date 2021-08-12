using UnityEngine;

namespace ProjectKritskiy
{
    public class WeaponFactory : IWeaponFactory
    {
        private readonly WeaponData _weaponData;

        public WeaponFactory(WeaponData weaponData)
        {
            _weaponData = weaponData;
        }

        public Transform CreateWeapon()
        {
            return new GameObject("Weapon").transform;
        }
    }
}