using UnityEngine;

namespace ProjectKritskiy
{
    public sealed class WeaponController : IExecute
    {
        private readonly ViewServices _bulletService = new ViewServices();
        private readonly Rigidbody _unitBody;
        private readonly Transform _barrel;
        private readonly Vector3 _offset;

        private GameObject _bulletPrefab;
        private int _magazine;
        private int _maxMagazine;
        private int _playerAmmo;

        public WeaponController(int magazine, int maxMagazine, int playerAmmo, GameObject bulletPrefab)
        {
            _magazine = magazine;
            _maxMagazine = maxMagazine;
            _playerAmmo = playerAmmo;
            _bulletPrefab = bulletPrefab;

            _unitBody = GameObject.Find("Player").GetComponent<Rigidbody>();
            _offset = new Vector3(0f, 0f, 0.5f);
            _barrel = _unitBody.transform;
            _barrel.position += _offset;
        }

        public void Execute(float deltaTime)
        {
            if (Input.GetButtonDown(KeyboardManager.FIRE))
            {
                if (_magazine > 0)
                {
                    var bullet = _bulletService.Create(_bulletPrefab);
                    bullet.transform.position = _barrel.position;
                    bullet.GetComponent<Rigidbody>().AddForce(_barrel.forward * 100f);
                    _magazine -= 1;
                }
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                if (_playerAmmo >= _maxMagazine && _magazine < _maxMagazine)
                {
                    _playerAmmo = _playerAmmo - (_maxMagazine - _magazine);
                    _magazine = _maxMagazine;
                }
                else if(_playerAmmo < _maxMagazine)
                {
                    _magazine = _playerAmmo;
                    _playerAmmo = 0;
                }
            }
        }
    }
}