using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2___Even_Fibonacci_numbers
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // List containing all Fib numbers
            var FibList = new List<int>
            {
                1,2
            };

            double sum = 0;
            int i = 1;
            int currHighestInteger = 3;

            while(currHighestInteger < 4000000)
            {
                FibList.Add(FibList[i - 1] + FibList[i]);
                currHighestInteger = FibList[i];
                if(FibList[i] % 2 == 0)
                {
                    sum += FibList[i];
                }
                i++;
            }

            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
