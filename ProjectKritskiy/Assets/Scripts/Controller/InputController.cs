namespace ProjectKritskiy
{
    public sealed class InputController : IExecute
    {
        private readonly IUserInputProxy _horizontal;
        private readonly float _yAxis;
        private readonly IUserInputProxy _vertical;

        public InputController((IUserInputProxy inputHorizontal, float yAxis, IUserInputProxy inputVertical) input)
        {
            _horizontal = input.inputHorizontal;
            _yAxis = input.yAxis;
            _vertical = input.inputVertical;
        }

        public void Execute(float deltaTime)
        {
            _horizontal.GetAxis();
            _vertical.GetAxis();
        }
    }
}