namespace Exercise.Assignment1
{
    public class RandomNumbers
    {
        private readonly int _count;
        private readonly Random _rand;

        public RandomNumbers(int count, int seed)
        {
            if(count > 0 || count < 1000)
            {
                _count = count;
                _rand = new Random(seed);
            }
        }


        public List<int> RandomValues(int minValue, int maxValue)
        {
            List<int> _list = new List<int>();
            if (minValue < 10 || minValue > 99)
            {
                Console.WriteLine("Illegal minValue" + minValue);
                return _list;
            }
            if (maxValue < 11 || maxValue > 100)
            {
                Console.WriteLine("Illegal maxvalue" + maxValue);
                return _list;
            }
            
            for(int i = 0; i < _count; i++)
            {
                _list.Add(_rand.Next());

            }

            return _list;
        }

        
    }
}