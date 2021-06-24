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
            return new GameObject("Player").AddRigidBody(60).AddCapsuleCollider().transform;
        }
    }
}