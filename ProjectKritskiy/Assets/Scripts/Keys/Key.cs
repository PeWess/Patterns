using System;
using UnityEngine;

namespace ProjectKritskiy
{
    public sealed class Key : IPickUp
    {
        public GameObject PickUpPrefab { get; }
        public Vector3Int Position { get; }

        public event Action OnPickUpChange = delegate { };

        public void KeyTaken()
        {
            OnPickUpChange.Invoke();
        }
    }
}