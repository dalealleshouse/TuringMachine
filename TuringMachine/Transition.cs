namespace TuringMachine
{
    public class Transition
    {
        public Transition(int initialState, char read, char write, HeadDirection headDirection, int nextState)
        {
            InitialState = initialState;
            Read = read;
            Write = write;
            HeadDirection = headDirection;
            NextState = nextState;
        }

        public int InitialState { get; }

        public char Read { get; }

        public char Write { get; }

        public HeadDirection HeadDirection { get; }

        public int NextState { get; }
    }
}