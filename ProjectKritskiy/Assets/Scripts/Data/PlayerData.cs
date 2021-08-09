using UnityEngine;

namespace ProjectKritskiy
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Units/PlayerData")]
    public sealed class PlayerData : ScriptableObject, IUnit
    {
        [SerializeField, Range(1, 100)] private float _health;
        [SerializeField, Range(100, 600)] private int _ammo;
        [SerializeField, Range(0, 100)] private float _speed;
        [SerializeField] private Vector3Int _position;

        public float Health => _health;
        public int Ammo => _ammo;
        public float Speed => _speed;
        public Vector3Int Position => _position;

        public Rigidbody Rigidbody { get; set; }
    }
}