namespace Exercise.Assignment2
{
    public enum State
    {
        Red = 1,
        YellowToRed = 2,
        YellowToGreen = 3,
        Green = 4
    }

    public class StateMachine
    {
        public StateMachine(State initialState)
        {
            State _state = initialState;
            _state = State.Red;
        }

        public void DoTransition()
        {
        }
    }
}