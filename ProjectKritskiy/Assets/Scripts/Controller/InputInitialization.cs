namespace ProjectKritskiy
{
    internal sealed class InputInitialization : IInitialization
    {
        private IUserInputProxy _pcInputHorizontal;
        private IUserInputProxy _pcInputVertical;

        public InputInitialization()
        {
            _pcInputHorizontal = new PCInputHorizontal();
            _pcInputVertical = new PCInputVertical();
        }

        public void Initialization()
        {
        }

        public (IUserInputProxy inputHorizontal, float yAxis, IUserInputProxy inputVertical) GetInput()
        {
            (IUserInputProxy inputHorizontal, float yAxis, IUserInputProxy inputVertical) result = (_pcInputHorizontal, 0.0f, _pcInputVertical);
            return result;
        }
    }
}