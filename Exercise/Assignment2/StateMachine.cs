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
        readonly State state;
        State _visiblestate;
        
        public StateMachine(State initialState)
        {
            state = initialState;
            //state = State.Red;
            for (int i = 0; i < 4; i++)
            {
                DoTransition();
            }
        }


        public void DoTransition()
        {
            _visiblestate = state;
            switch (_visiblestate)
            { 
                case State.Red:
                    _visiblestate = State.YellowToGreen;
                    break;
                case State.YellowToGreen:
                    _visiblestate = State.Green;
                    break;
                case State.Green:
                    _visiblestate= State.YellowToRed;
                    break;
                case State.YellowToRed:
                    _visiblestate = State.Red;
                    break;

            }
            Console.WriteLine(_visiblestate);
        }
    }
}