using UnityEngine;

namespace ProjectKritskiy
{
    public class MedKitInitialization : IInitialization
    {
        private readonly IMedKitFactory _medKitFactory;
        private Transform _medKitPosition;

        public MedKitInitialization(IMedKitFactory medKitFactory, Vector3Int medKit)
        {
            _medKitFactory = medKitFactory;
            _medKitPosition = _medKitFactory.CreateMedKit();
            _medKitPosition.position = medKit;
        }

        public void Initialization()
        {
        }
    }
}