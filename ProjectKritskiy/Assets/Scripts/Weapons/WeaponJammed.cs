namespace ProjectKritskiy
{
    public sealed class WeaponJammed
    {
        public bool IsJammed { get; set; }

        public WeaponJammed(bool isJammed)
        {
            IsJammed = isJammed;
        }
    }
}