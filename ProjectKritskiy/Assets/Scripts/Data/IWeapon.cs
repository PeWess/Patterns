using UnityEngine;

namespace ProjectKritskiy
{
    public interface IWeapon
    {
        int MaxMagazine { get; }
        int Magazine { get; }
        GameObject BulletPrefab { get; }
    }
}