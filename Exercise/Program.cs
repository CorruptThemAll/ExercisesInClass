// See https://aka.ms/new-console-template for more information
using Exercise.Assignment1;
using Exercise.Assignment2;

Console.WriteLine("Hello, World!");
RandomNumbers _randy = new RandomNumbers(12, 19);
List<int> _listy = _randy.RandomValues(12, 19);

foreach(var number in _listy)
{
    Console.WriteLine(number);
}


Console.WriteLine("fucking kill me");

StateMachine _stateMachine = new StateMachine(State.Red);


Console.ReadLine();
