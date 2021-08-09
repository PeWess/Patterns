using UnityEngine;

namespace ProjectKritskiy
{
    public sealed class PlayerFactory : IPlayerFactory
    {
        private readonly PlayerData _playerData;

        public PlayerFactory(PlayerData playerData)
        {
            _playerData = playerData;
        }

        public Transform CreatePlayer()
        {
            var player = new GameObject("Player").AddRigidBody(60).AddCapsuleCollider();
            _playerData.Rigidbody = player.GetComponent<Rigidbody>();
            return player.transform;
        }
    }
}