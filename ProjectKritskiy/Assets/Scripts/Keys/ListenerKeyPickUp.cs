using System.Collections.Generic;
using UnityEngine;

namespace ProjectKritskiy
{
    public sealed class ListenerKeyPickUp
    {
        private readonly List<Key> _keys = new List<Key>(3);

        public void Add(Key value)
        {
            value.OnPickUpChange += ValueOnPickUpChange;
            _keys.Add(value);
        }

        public void Remove(Key value)
        {
            value.OnPickUpChange -= ValueOnPickUpChange;
            _keys.Remove(value);
        }

        private void ValueOnPickUpChange()
        {
            Debug.Log("Key picked up");
        }
    }
}