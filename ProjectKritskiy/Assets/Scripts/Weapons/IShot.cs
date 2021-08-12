using UnityEngine;

namespace ProjectKritskiy
{
    public interface IShot
    {
        void Shot(ViewServices bulletService, GameObject bulletPrefab, Transform barrel);
    }
}