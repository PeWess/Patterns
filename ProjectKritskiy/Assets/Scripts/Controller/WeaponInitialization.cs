using UnityEngine;

namespace ProjectKritskiy
{
    internal sealed class WeaponInitialization : IInitialization
    {
        private readonly IWeaponFactory _weaponFactory;
        private Transform _weaponPosition;

        public WeaponInitialization(IWeaponFactory weaponFactory, Vector3Int weapon)
        {
            _weaponFactory = weaponFactory;
            _weaponPosition = _weaponFactory.CreateWeapon();
            _weaponPosition.position = weapon;
        }

        public void Initialization()
        {
        }
    }
}