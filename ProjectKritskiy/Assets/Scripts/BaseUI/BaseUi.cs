using UnityEngine;

namespace ProjectKritskiy
{
    internal abstract class BaseUi : MonoBehaviour
    {
        public abstract void Execute();
        public abstract void Cancel();
    }
}