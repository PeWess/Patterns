using UnityEngine;

namespace ProjectKritskiy
{
    public sealed class PickUpFactory : IPickUpFactory
    {
        private readonly MedKitData _medKitData;
        private readonly PowerUpData _powerUpData;
        private readonly KeyData _keyData;

        public PickUpFactory(MedKitData medKitData, PowerUpData powerUpData, KeyData keyData)
        {
            _medKitData = medKitData;
            _powerUpData = powerUpData;
            _keyData = keyData;
        }

        public Transform CreateMedKit()
        {
            return new GameObject("MedKit").AddBoxTrigger().transform;
        }
        
        public Transform CreatePowerUp()
        {
            return new GameObject("PowerUp").AddBoxTrigger().transform;
        }
        
        public Key CreateKey()
        {
            Key key = new Key();
            var listenerKeyPickUp = new ListenerKeyPickUp();
            listenerKeyPickUp.Add(key);
            return key;
        }
    }
}