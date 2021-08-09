using System.Collections.Generic;
using UnityEngine;

namespace ProjectKritskiy
{
    public sealed class ViewServices
    {
        private readonly Dictionary<int, ObjectPool> _viewCache = new Dictionary<int, ObjectPool>();

        public GameObject Create(GameObject prefab)
        {
            if (!_viewCache.TryGetValue(prefab.GetInstanceID(), out ObjectPool viewPool))
            {
                viewPool = new ObjectPool(prefab);
                _viewCache[prefab.GetInstanceID()] = viewPool;
            }

            return viewPool.Pop();
        }

        public void Destroy(GameObject prefab)
        {
            _viewCache[prefab.GetInstanceID()].Push(prefab);
        }
    }
}