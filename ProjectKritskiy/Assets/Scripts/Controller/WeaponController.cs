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
        private IShot _currentWeapon;
        private IShot _weaponProxy;
        private WeaponJammed _weaponJammed;
        private int _magazine;
        private int _maxMagazine;
        private int _playerAmmo;

        public WeaponController(IShot currentWeapon, int magazine, int maxMagazine, int playerAmmo, GameObject bulletPrefab, Rigidbody rigidbody)
        {
            _magazine = magazine;
            _maxMagazine = maxMagazine;
            _playerAmmo = playerAmmo;
            _bulletPrefab = bulletPrefab;

            _unitBody = rigidbody;
            _offset = new Vector3(0f, 0f, 0.5f);
            _barrel = _unitBody.transform;
            _barrel.position += _offset;

            _weaponJammed = new WeaponJammed(false);
            _currentWeapon = currentWeapon;
            _weaponProxy = new WeaponProxy(_currentWeapon, _weaponJammed);
        }

        public void Execute(float deltaTime)
        {
            if (Input.GetButtonDown(ButtonManager.FIRE))
            {
                if (_magazine > 0)
                {
                    _weaponProxy.Shot(_bulletService, _bulletPrefab, _barrel);
                    if(_weaponJammed.IsJammed == false) _magazine -= 1;
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