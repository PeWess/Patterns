namespace ProjectKritskiy
{
    internal sealed class MouseInitialization : IInitialization
    {
        private IUserInputProxy _pcMouseHorizontal;
        private IUserInputProxy _pcMouseVertical;

        public MouseInitialization()
        {
            _pcMouseHorizontal = new PCMouseHorizontal();
            _pcMouseVertical = new PCMouseVertical();
        }

        public void Initialization()
        {
        }

        public (IUserInputProxy mouseHorizontal, IUserInputProxy mouseVertical) GetInput()
        {
            (IUserInputProxy mouseHorizontal, IUserInputProxy mouseVertical) result = (_pcMouseHorizontal, _pcMouseVertical);
            return result;
        }
    }
}