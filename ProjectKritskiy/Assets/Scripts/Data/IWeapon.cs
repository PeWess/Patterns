using UnityEngine;

namespace ProjectKritskiy
{
    public interface IWeapon
    {
        IShot WeaponType { get; set; }
        int MaxMagazine { get; set; }
        int Magazine { get; }
        int Damage { get; set; }
        GameObject BulletPrefab { get; }
    }
}