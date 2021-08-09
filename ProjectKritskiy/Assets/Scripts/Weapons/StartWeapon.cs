using UnityEngine;

namespace ProjectKritskiy
{
    public sealed class StartWeapon : IShot
    {
        public void Shot(ViewServices bulletService, GameObject bulletPrefab, Transform barrel)
        {
            var bullet = bulletService.Create(bulletPrefab);
            bullet.AddRigidBody(0.1f);
            bullet.transform.position = barrel.position;
            bullet.GetComponent<Rigidbody>().AddForce(barrel.forward * 100f);
        }
    }
}