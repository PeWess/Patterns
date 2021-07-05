using UnityEngine;

namespace ProjectKritskiy
{
    [CreateAssetMenu(fileName = "WeaponData", menuName = "Data/Weapons/WeaponData")]
    public sealed class WeaponData : ScriptableObject, IWeapon
    {
        [SerializeField, Range(6, 200)] private int _maxMagazine;
        [SerializeField, Range(6, 200)] private int _magazine;
        [SerializeField] private GameObject _bulletPrefab;

        public int MaxMagazine => _maxMagazine;
        public int Magazine => _magazine;
        public GameObject BulletPrefab => _bulletPrefab;
    }
}