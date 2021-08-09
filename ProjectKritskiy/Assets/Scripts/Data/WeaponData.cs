using UnityEngine;

namespace ProjectKritskiy
{
    [CreateAssetMenu(fileName = "WeaponData", menuName = "Data/Weapons/WeaponData")]
    public sealed class WeaponData : ScriptableObject, IWeapon
    {
        [SerializeField, Range(6, 200)] private int _maxMagazine;
        [SerializeField, Range(6, 200)] private int _magazine;
        [SerializeField, Range(10, 100)] private int _damage;
        [SerializeField] private GameObject _bulletPrefab;
        private IShot _weaponType;

        public IShot WeaponType
        {
            get => _weaponType;
            set => _weaponType = value;
        }

        public int MaxMagazine
        {
            get => _maxMagazine;
            set => _maxMagazine = value;
        }

        public int Magazine => _magazine;
        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }

        public GameObject BulletPrefab => _bulletPrefab;
    }
}