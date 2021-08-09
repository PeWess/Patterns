using UnityEngine;

namespace ProjectKritskiy
{
    public sealed class PickUpFactory : IPickUpFactory
    {
        private readonly MedKitData _medKitData;
        private readonly PowerUpData _powerUpData;

        public PickUpFactory(MedKitData medKitData, PowerUpData powerUpData)
        {
            _medKitData = medKitData;
            _powerUpData = powerUpData;
        }

        public Transform CreateMedKit()
        {
            return new GameObject("MedKit").AddBoxTrigger().transform;
        }
        
        public Transform CreatePowerUp()
        {
            return new GameObject("PowerUp").AddBoxTrigger().transform;
        }
    }
}