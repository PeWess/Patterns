namespace ProjectKritskiy
{
    public sealed class MouseController : IExecute
    {
        private readonly IUserInputProxy _mouseHorizontal;
        private readonly IUserInputProxy _mouseVertical;

        public MouseController((IUserInputProxy mouseHorizontal, IUserInputProxy mouseVertical) input)
        {
            _mouseHorizontal = input.mouseHorizontal;
            _mouseVertical = input.mouseVertical;
        }

        public void Execute(float deltaTime)
        {
            _mouseHorizontal.GetAxis();
            _mouseVertical.GetAxis();
        }
    }
}