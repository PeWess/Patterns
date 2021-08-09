using UnityEngine;

namespace ProjectKritskiy
{
    public class PickUpInitialization : IInitialization
    {
        private readonly IPickUpFactory _pickUpFactory;
        private Transform _medKitPosition;
        private Transform _powerUpPosition;

        public PickUpInitialization(IPickUpFactory pickUpFactory, Vector3Int medKit, Vector3Int powerUp)
        {
            _pickUpFactory = pickUpFactory;
            
            _medKitPosition = _pickUpFactory.CreateMedKit();
            _medKitPosition.position = medKit;
            
            _powerUpPosition = _pickUpFactory.CreatePowerUp();
            _powerUpPosition.position = powerUp;
        }

        public void Initialization()
        {
        }
    }
}