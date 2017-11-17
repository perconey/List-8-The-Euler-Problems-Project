using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4___Largest_palindrome_product
{
    class Program
    {
        static bool isPalindrome(long number)
        {
            bool returnedBool = true;
            int i, j;
            var numStr = number.ToString();
            for (i = 0, j = numStr.Length - 1; i < numStr.Length - 1; i++, j--)
            {
                if(numStr[i] == numStr[j])
                {
                    continue;
                }
                returnedBool = false;
                break;
            }
            return returnedBool;
        }

        static void Main(string[] args)
        {
            int i, j, product1 = 0, product2 = 0;
            
            int largestPalindrome = 0;

            for(i = 100;i < 999; i++)
            {
                for(j = 999; j > 101; j--)
                {
                    if(isPalindrome(j * i))
                    {
                        Console.WriteLine($"Pr 1: {i} - Pr 2: {j} --> Product : {i*j}");
                        if(largestPalindrome < i * j)
                        {
                            product1 = i;
                            product2 = j;
                            largestPalindrome = i * j;
                        }
                    }
                }
            }
            Console.WriteLine($"\nThe largest palindrome possible to made from given numbers is {largestPalindrome}\n" +
                $"It is made from multipilcation of {product1} and {product2} \n\n\n\n");
            Console.ReadLine();
        }
    }
}
