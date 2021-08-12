namespace ProjectKritskiy
{
    public sealed class Context
    {
        private State _state;

        public Context(State state)
        {
            _state = state;
        }

        public State State
        {
            set
            {
                _state = value;
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}