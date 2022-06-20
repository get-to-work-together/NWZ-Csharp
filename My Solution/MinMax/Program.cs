using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = MinMax(new int[] { 1, 7, 3, 4 });
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static Tuple<int, int> MinMax(int[] numbers)
        {
            var minimum = numbers[0];
            var maximum = numbers[0];
            foreach (var number in numbers.Skip(1))
            {
                if (number < minimum) minimum = number;
                else if (number > maximum) maximum = number;
            }
            return new Tuple<int, int>(minimum, maximum);
        }
    }

}
