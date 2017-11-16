using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3___Largest_prime_factor
{
    class Program
    {

        static void Main(string[] args)
        {
            long number = 600851475143;
            long updatedNumber = number;
            long largestFact = 0;

            int counter = 2;
            while (counter * counter <= updatedNumber)
            {
                if (updatedNumber % counter == 0)
                {
                    updatedNumber = updatedNumber / counter;
                    largestFact = counter;
                }
                else
                {
                    counter++;
                }
            }
            if (updatedNumber > largestFact)
            {
                largestFact = updatedNumber;
            }
            Console.ReadKey();

        }
    }
}
