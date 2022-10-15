namespace Exercise.Assignment2
{
    public enum State
    {
        Red = 1,
        YellowToGreen = 2,
        Green = 3,
        YellowToRed = 4,
    }

    public class StateMachine
    {
        readonly State state;
        State _visiblestate;
        
        public StateMachine(State initialState)
        {
            state = initialState;
            
            for (int i = 0; i < 4; i++)
            {
                DoTransition();
                state++;
            }
        }


        public void DoTransition()
        {

            _visiblestate = state;
            switch (_visiblestate)
            {
                case State.Red:
                    Console.WriteLine(_visiblestate);
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