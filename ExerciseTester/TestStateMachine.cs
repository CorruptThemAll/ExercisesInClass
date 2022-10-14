using Exercise_Solution.Assignment2_solution;
using static NUnit.Framework.Assert;

namespace ExerciseTester
{
    internal class TestStateMachine
    {
        private StringWriter _stringWriter;

        [SetUp]
        public void SetUp()
        {
            PrepareWriter();
        }

        [Test]
        public void Transition_From_Green_To_YellowToRed()
        {
            //Arrange
            const State initialState = State.Green;
            var stateMachine = new StateMachine(initialState);

            // Act
            stateMachine.DoTransition();


            //Assert
            var res = stateMachine.State;
            That(res, Is.EqualTo(State.YellowToRed));
            That(_stringWriter.ToString(), Does.Contain("YELLOW"));
        }

        [Test]
        public void Transition_From_YellowToRed_To_Red()
        {
            //Arrange
            var initialState = State.YellowToRed;
            StateMachine stateMachine = new StateMachine(initialState);

            // Act
            stateMachine.DoTransition();


            //Assert
            var res = stateMachine.State;
            That(res, Is.EqualTo(State.Red));
            That(_stringWriter.ToString(), Does.Contain("RED"));
        }

        [Test]
        public void Transition_From_Red_YellowToGreen()
        {
            //Arrange
            var initialState = State.Red;
            StateMachine stateMachine = new StateMachine(initialState);

            // Act
            stateMachine.DoTransition();


            //Assert
            var res = stateMachine.State;
            That(res, Is.EqualTo(State.YellowToGreen));
            That(_stringWriter.ToString(), Does.Contain("YELLOW"));
            That(_stringWriter.ToString(), Does.Contain("RED"));
        }

        [Test]
        public void Transition_From_YellowToGreen_To_Green()
        {
            //Arrange
            var initialState = State.YellowToGreen;
            StateMachine stateMachine = new StateMachine(initialState);

            // Act
            stateMachine.DoTransition();


            //Assert
            var res = stateMachine.State;
            That(res, Is.EqualTo(State.Green));
            That(_stringWriter.ToString(), Does.Contain("GREEN"));
        }

        private void PrepareWriter()
        {
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
        }
    }
}