using System.IO;
using UnityEngine;

namespace ProjectKritskiy
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
    public sealed class Data : ScriptableObject
    {
        [SerializeField] private string _playerDataPath;
        [SerializeField] private string _weaponDataPath;
        [SerializeField] private string _medKitDataPath;
        [SerializeField] private string _powerUpDataPath;
        [SerializeField] private string _keyDataPath;
        private PlayerData _player;
        private WeaponData _weapon;
        private MedKitData _medKit;
        private PowerUpData _powerUp;
        private KeyData _key;

        public PlayerData Player
        {
            get
            {
                if (_player == null)
                {
                    _player = Load<PlayerData>("Data/" + _playerDataPath);
                }

                return _player;
            }
        }

        public WeaponData Weapon
        {
            get
            {
                if (_weapon == null)
                {
                    _weapon = Load<WeaponData>("Data/" + _weaponDataPath);
                }

                return _weapon;
            }
        }
        
        public MedKitData MedKit
        {
            get
            {
                if (_medKit == null)
                {
                    _medKit = Load<MedKitData>("Data/" + _medKitDataPath);
                }

                return _medKit;
            }
        }
        
        public PowerUpData PowerUp
        {
            get
            {
                if (_powerUp == null)
                {
                    _powerUp = Load<PowerUpData>("Data/" + _powerUpDataPath);
                }

                return _powerUp;
            }
        }
        
        public KeyData Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Load<KeyData>("Data/" + _keyDataPath);
                }

                return _key;
            }
        }

        private T Load<T>(string resourcesPath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }
}