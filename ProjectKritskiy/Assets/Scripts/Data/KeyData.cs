using UnityEngine;

namespace ProjectKritskiy
{
    [CreateAssetMenu(fileName = "KeyData", menuName = "Data/PickUps/KeyData")]
    public class KeyData : ScriptableObject, IPickUp
    {
        [SerializeField] private GameObject _keyPrefab;
        [SerializeField] private Vector3Int _position;

        public GameObject PickUpPrefab => _keyPrefab;
        public Vector3Int Position => _position;
    }
}