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
        public StateMachine(State initialState)
        {
            state = initialState;
            state = State.Red;  
        }


        public void DoTransition()
        {
            switch (state)
            { 

            }
        }
    }
}