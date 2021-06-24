using System.IO;
using UnityEngine;

namespace ProjectKritskiy
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
    public sealed class Data : ScriptableObject
    {
        [SerializeField] private string _playerDataPath;
        [SerializeField] private string _weaponDataPath;
        private PlayerData _player;
        private WeaponData _weapon;

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

        private T Load<T>(string resourcesPath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }
}