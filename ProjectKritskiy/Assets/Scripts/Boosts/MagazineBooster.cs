namespace ProjectKritskiy
{
    internal sealed class MagazineBooster : PowerUpBoost
    {
        private readonly int _maxMagazine;

        public MagazineBooster(WeaponData weapon, int maxMagazine) : base(weapon)
        {
            _maxMagazine = maxMagazine;
        }

        public override void Handle()
        {
            if (_weapon.MaxMagazine < _maxMagazine)
            {
                _weapon.MaxMagazine = _maxMagazine;
            }
            
            base.Handle();
        }
    }
}