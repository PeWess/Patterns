namespace ProjectKritskiy
{
    internal sealed class DamageBooster : PowerUpBoost
    {
        private readonly int _damage;

        public DamageBooster(WeaponData weapon, int damage) : base(weapon)
        {
            _damage = damage;
        }

        public override void Handle()
        {
            _weapon.Damage += _damage;
            base.Handle();
        }
    }
}