using UnityEngine;

namespace ProjectKritskiy
{
    public interface IPickUpFactory
    {
        Transform CreateMedKit();
        Transform CreatePowerUp();
    }
}