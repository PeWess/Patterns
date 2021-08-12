using UnityEngine;

namespace ProjectKritskiy
{
    [CreateAssetMenu(fileName = "PowerUpData", menuName = "Data/PickUps/PowerUpData")]
    public class PowerUpData : ScriptableObject, IPickUp
    {
        [SerializeField, Range(100, 500)] private int _healthBoost;
        [SerializeField, Range(50, 100)] private int _damageBoost;
        [SerializeField] private GameObject _PowerUpPrefab;
        [SerializeField] private Vector3Int _position;

        public GameObject PickUpPrefab => _PowerUpPrefab;
        public Vector3Int Position => _position;
    }
}