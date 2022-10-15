namespace Exercise.Assignment2
{
    public enum State
    {
        //Original setup
        Red = 1,
        YellowToRed = 2,
        YellowToGreen = 3,
        Green = 4
        //Måske lige meget
        // Red = 1,
        // YellowToGreen = 2,
        // Green = 3,
        // YellowToRed = 4
    }

    public class StateMachine
    {
        private readonly State state; //min readonly state
        private State _visiblestate; //Anden variable som kan ændres

        public StateMachine(State initialState)
        {
            state = initialState; //siger at initialstate skal hedde state i constructor, initialstate kan man declare i program.cs
            _visiblestate = state; //Det eneste sted jeg kunne bruge de to variabler og sæt dem ligemed hinanden uden at være trapped i mit loop til at lave gentagelser.
            

            for (int i = 0; i < 8; i++) //Loop til der sikre at den kommer videre til den næste case.
            {
                DoTransition(); //Kalder på metoden
                //state++; //Siger at den skal tilføje 1 til enum.... Var der til at fixe mit loops logik da jeg havde visiblestate = state
            }
        }


        public void DoTransition() //Metoden
        {

            //_visiblestate = state; Et levn fra den tid mit loop var bugged.
            switch (_visiblestate)
            {
                case State.Red:
                    Console.WriteLine("RED");
                    _visiblestate = State.YellowToGreen;
                    break;
                case State.YellowToGreen:
                    Console.WriteLine("RED YELLOW");
                    _visiblestate = State.Green;
                    break;
                case State.Green:
                    Console.WriteLine("GREEN");
                    _visiblestate= State.YellowToRed;
                    break;
                case State.YellowToRed:
                    Console.WriteLine("YELLOW");
                    _visiblestate = State.Red;
                    break;

            }
            
        }
    }
}