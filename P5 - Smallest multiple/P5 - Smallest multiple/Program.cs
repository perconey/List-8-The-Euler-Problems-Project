using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5___Smallest_multiple
{
    class Program
    {

        static bool isSmallestMultiple(long number)
        {
            string strint = number.ToString();
            int i,sum = 0;

            //20
             if (number % 10 != 0 || (int)Char.GetNumericValue(strint[strint.Length - 1]) != 0)
            {
                return false;
            }
            
            // Sum of numbers
            for (i = strint.Length - 1; i >= 0; i--)
            {
                sum += (int)Char.GetNumericValue(strint[i]);
            }

            //3 , 9
            if (sum % 3 != 0 || sum % 9 != 0)
            {
                return false;
            }

            //4
            if(((int)Char.GetNumericValue(strint[strint.Length - 1]) + (int)Char.GetNumericValue(strint[strint.Length - 2]))  % 4 != 0)
            {
                return false;
            }

            //11
            int oddSum = 0, evenSum = 0;
            for(i = strint.Length - 1; i >= 0; i--)
            {
                if(i % 2 == 0)
                {
                    evenSum += (int)Char.GetNumericValue(strint[i]);
                }
                else
                {
                    oddSum += (int)Char.GetNumericValue(strint[i]);
                }

                if(i == 0)
                {
                    if(oddSum - evenSum % 11 != 0)
                    {
                        return false;
                    }
                }
            }

            int loops = 0, sumOnTheBack = 0, sumFromTheBeggining = 0;
            for(i = strint.Length - 1; i >= 0; i--)
            {
                loops++;

                if (loops < 4)
                {
                    sumOnTheBack += (int)Char.GetNumericValue(strint[i]);
                }
                else
                {
                    sumFromTheBeggining += (int)Char.GetNumericValue(strint[i]);
                }
            }

            int div = sumOnTheBack - sumFromTheBeggining;
            if(div % 13 != 0)
            {
                return false;
            }

           


            return true;
        }

        static void Main(string[] args)
        {
            bool foundIt = false;
            long theOne = 0;
            for(int i = 1001; foundIt == false; i++)
            {
                //Console.WriteLine(i);
                foundIt = isSmallestMultiple(i);
                theOne = i;
            }

            Console.WriteLine(theOne);
            Console.ReadKey();
        }
    }
}
