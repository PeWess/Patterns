using UnityEngine;

namespace ProjectKritskiy
{
    public class WeaponProxy : IShot
    {
        private readonly IShot _weaponType;
        private readonly WeaponJammed _weaponJammed;

        public WeaponProxy(IShot weaponType, WeaponJammed weaponJammed)
        {
            _weaponType = weaponType;
            _weaponJammed = weaponJammed;
        }
        
        public void Shot(ViewServices bulletService, GameObject bulletPrefab, Transform barrel)
        {
            if (_weaponJammed.IsJammed == false)
            {
                _weaponType.Shot(bulletService, bulletPrefab, barrel);
            }
        }
    }
}