using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6___Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            long sumOfSquares = 0;
            long squareOfSum = 0;

            int n = 100;
            int a100 = 100;
            sumOfSquares = n *(a100 + 1) / 2;

            squareOfSum = (n *(n + 1) *(2 *n + 1)) /6;

            Console.WriteLine(sumOfSquares * sumOfSquares - squareOfSum);
            Console.ReadKey();
        }
    }
}
