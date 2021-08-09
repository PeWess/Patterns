using UnityEngine;

namespace ProjectKritskiy
{
    internal class PowerUpBoost
    {
        protected WeaponData _weapon;
        protected PowerUpBoost Next;

        public PowerUpBoost(WeaponData weapon)
        {
            _weapon = weapon;
        }

        public void Boost(PowerUpBoost parameter)
        {
            if (Next != null)
            {
                Next.Boost(parameter);
            }
            else
            {
                Next = parameter;
            }
        }

        public virtual void Handle() => Next?.Handle();
    }
}