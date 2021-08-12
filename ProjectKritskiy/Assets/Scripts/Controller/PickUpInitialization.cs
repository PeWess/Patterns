using UnityEngine;

namespace ProjectKritskiy
{
    public class PickUpInitialization : IInitialization
    {
        private readonly IPickUpFactory _pickUpFactory;
        private Transform _medKitPosition;
        private Transform _powerUpPosition;
        private Vector3Int _keyPosition;

        public PickUpInitialization(IPickUpFactory pickUpFactory, Vector3Int medKit, Vector3Int powerUp, Vector3Int key)
        {
            _pickUpFactory = pickUpFactory;
            
            _medKitPosition = _pickUpFactory.CreateMedKit();
            _medKitPosition.position = medKit;
            
            _powerUpPosition = _pickUpFactory.CreatePowerUp();
            _powerUpPosition.position = powerUp;
            
            _keyPosition = _pickUpFactory.CreateKey().Position;
        }

        public void Initialization()
        {
        }
    }
}