using UnityEngine;

namespace ProjectKritskiy
{
    [CreateAssetMenu(fileName = "MedKitData", menuName = "Data/PickUps/MedKitData")]
    public class MedKitData : ScriptableObject, IPickUp
    {
        [SerializeField, Range(1, 100)] private int _heal;
        [SerializeField] private GameObject _medKitPrefab;
        [SerializeField] private Vector3Int _position;

        public GameObject PickUpPrefab => _medKitPrefab;
        public Vector3Int Position => _position;
    }
}