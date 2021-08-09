using UnityEngine;

namespace ProjectKritskiy
{
    public interface IPickUp
    {
        GameObject PickUpPrefab { get; }
        Vector3Int Position { get; }
    }
}