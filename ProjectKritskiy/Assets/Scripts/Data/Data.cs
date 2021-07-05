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
        private PlayerData _player;
        private WeaponData _weapon;
        private MedKitData _medKit;

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

        private T Load<T>(string resourcesPath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }
}