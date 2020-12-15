using System;
using System.Collections.Generic;

namespace Tuplas
{
    class Program
    {

        static void Main(string[] args)
        {
            MaxMin();
        }


        private  static void MaxMin()
        {
            var number = new int[] { 10,15,0,80,2,120,9};
            var result = ObtenerElMaximoyMinimo(number);

            Console.WriteLine($"{result.Max},{result.Min}");
        }

        private static (int Max, int Min) ObtenerElMaximoyMinimo(IEnumerable<int> numbers)
        {
            int Max = int.MinValue;
            int Min = int.MaxValue;

            foreach (var item in numbers)
            {
                Min = (item < Min) ? item : Min;
                Max = (item > Max) ? item : Max;
            }
            return (Max, Min);
        }
    }
}
