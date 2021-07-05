using UnityEngine;

namespace ProjectKritskiy
{
    public sealed class MedKitFactory : IMedKitFactory
    {
        private readonly MedKitData _medKitData;

        public MedKitFactory(MedKitData medKitData)
        {
            _medKitData = medKitData;
        }

        public Transform CreateMedKit()
        {
            return new GameObject("MedKit").AddBoxTrigger().transform;
        }
    }
}