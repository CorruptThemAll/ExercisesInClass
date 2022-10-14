using Exercise_Solution.Assignment1_Solution;
using static NUnit.Framework.Assert;

namespace ExerciseTester
{
    public class TestLoops
    {
        private StringWriter? _stringWriter;

        [SetUp]
        public void Setup()
        {
            PrepareWriter();
        }

        [Test]
        public void Loop_Count_10_Valid_Numbers()
        {
            // Arrange 
            RandomNumbers sut = new(10, 2);

            // Act
            var res = sut.RandomValues(10, 30);

            var expected = new List<int>() { 26, 18, 13, 30, 12, 16, 26, 19, 14, 10 };
            That(res, Has.Count.EqualTo(10));
            That(res, Is.EqualTo(expected));
        }

        [Test]
        public void Loop_Count_0_Valid()
        {
            // Arrange 
            const int count = 0;

            // Act
            new RandomNumbers(count, 2);

            That(string.IsNullOrEmpty(_stringWriter?.ToString()), Is.True);
        }

        [Test]
        public void Loop_Count_1000_Valid()
        {
            // Arrange 
            const int count = 1000;

            // Act
            new RandomNumbers(count, 2);

            That(string.IsNullOrEmpty(_stringWriter?.ToString()), Is.True);
        }

        [Test]
        public void Loop_Count_negative_Invalid()
        {
            // Arrange 
            const int count = -1;

            // Act
            new RandomNumbers(count, 2);

            That(_stringWriter?.ToString().Contains("Illegal count -1"), Is.True);
        }

        [Test]
        public void Loop_Count_1001Invalid()
        {
            // Arrange 
            const int count = 1001;

            // Act
            RandomNumbers sut = new(count, 2);

            That(_stringWriter != null && _stringWriter.ToString().Contains("Illegal count 1001"));
        }

        [Test]
        public void Loop_Min_Greater_Than_Max()
        {
            // Arrange 
            const int min = 20;
            const int max = 19;
            RandomNumbers sut = new(10, 2);

            // Act
            var res = sut.RandomValues(min, max);

            That(res, Is.Empty);
            That(_stringWriter != null &&
                 _stringWriter.ToString().Contains("Max 19 must be greater than min 20"), Is.True);
        }

        [Test]
        public void Loop_Min_Less_Than_10()
        {
            // Arrange 
            const int min = 9;
            const int max = 10;
            RandomNumbers sut = new(10, 2);

            // Act
            var res = sut.RandomValues(min, max);

            That(res, Is.Empty);
            That(_stringWriter != null &&
                 _stringWriter.ToString().Contains("Illegal minimum 9"), Is.True);
        }

        [Test]
        public void Loop_Min_Greater_Than_99()
        {
            // Arrange 
            const int min = 100;
            const int max = 102;
            RandomNumbers sut = new(10, 2);

            // Act
            var res = sut.RandomValues(min, max);

            That(res, Is.Empty);
            That(_stringWriter != null &&
                 _stringWriter.ToString().Contains("Illegal minimum 100"), Is.True);
        }

        [Test]
        public void Loop_Max_Less_Than_11()
        {
            // Arrange 
            const int min = 10;
            const int max = 10;
            RandomNumbers sut = new(10, 2);

            // Act
            var res = sut.RandomValues(min, max);
            That(res, Is.Empty);
            That(_stringWriter != null &&
                 _stringWriter.ToString().Contains("Illegal maximum 10"), Is.True);
        }


        [Test]
        public void Loop_Max_Greater_Than_100()
        {
            // Arrange 
            const int min = 11;
            const int max = 101;
            RandomNumbers sut = new(10, 2);

            // Act
            var res = sut.RandomValues(min, max);

            That(res, Is.Empty);
            That(_stringWriter != null &&
                 _stringWriter.ToString().Contains("Illegal maximum 101"), Is.True);
        }


        private void PrepareWriter()
        {
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
        }
    }
}