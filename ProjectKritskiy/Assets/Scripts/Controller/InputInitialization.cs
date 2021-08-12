namespace ProjectKritskiy
{
    internal sealed class InputInitialization : IInitialization
    {
        private IUserInputProxy _pcInputHorizontal;
        private IUserInputProxy _pcInputVertical;
        private IUserInputProxy _pcMouseHorizontal;
        private IUserInputProxy _pcMouseVertical;

        public InputInitialization()
        {
            _pcInputHorizontal = new PCInputHorizontal();
            _pcInputVertical = new PCInputVertical();
            _pcMouseHorizontal = new PCMouseHorizontal();
            _pcMouseVertical = new PCMouseVertical();
        }

        public void Initialization()
        {
        }

        public (IUserInputProxy inputHorizontal, float yAxis, IUserInputProxy inputVertical) GetInput()
        {
            (IUserInputProxy inputHorizontal, float yAxis, IUserInputProxy inputVertical) result = (_pcInputHorizontal, 0.0f, _pcInputVertical);
            return result;
        }
        
        public (IUserInputProxy mouseHorizontal, IUserInputProxy mouseVertical) GetMouseInput()
        {
            (IUserInputProxy mouseHorizontal, IUserInputProxy mouseVertical) result = (_pcMouseHorizontal, _pcMouseVertical);
            return result;
        }
    }
}