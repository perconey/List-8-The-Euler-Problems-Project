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
            int i, sum, nmod, thirmod;
            int powerOf3, oddSum, evenSum;
            long loops, numOnTheBack, numOnTheStart, check16, powerOf10;
            double div;


            //Console.WriteLine(number);
            //20
            if ((int)Char.GetNumericValue(strint[strint.Length - 1]) != 0)
            {
                if((int)Char.GetNumericValue(strint[strint.Length - 2]) != 0 || (int)Char.GetNumericValue(strint[strint.Length - 2]) != 1)
                {
                        return false;                   
                }
            }

            //19
            //Console.WriteLine(number);

            List<int> elt = new List<int>();

            loops = 0;
            int x2 = 0;
            for (i = strint.Length - 1; i >= 0; i--)
            {
                loops++;
                if (loops == 1)
                {
                    x2 = (int)Char.GetNumericValue(strint[i]) * 2;
                    continue;
                }
                elt.Add((int)Char.GetNumericValue(strint[i]));
            }
            numOnTheStart = 0;
            loops = 0;
            powerOf10 = 10;
            for (i = 0; i < elt.Count; i++)
            {
                loops++;
                if (loops == 1)
                {
                    numOnTheStart += elt[i] * 1;
                    continue;
                }
                if (loops == 2)
                {
                    numOnTheStart += elt[i] * 10;
                    continue;
                }
                powerOf10 = powerOf10 * 10;

                numOnTheStart += elt[i] * powerOf10;
            }
            div = numOnTheStart + x2;
            if (div % 19 != 0)
            {
                return false;
            }

            //17
            //Console.WriteLine(number);
            List<int> elem = new List<int>();

            loops = 0;
            int x5 = 0;
            for (i = strint.Length - 1; i >= 0; i--)
            {
                loops++;
                if (loops == 1)
                {
                    x5 = (int)Char.GetNumericValue(strint[i]) * 5;
                    continue;
                }
                elem.Add((int)Char.GetNumericValue(strint[i]));
            }
            numOnTheStart = 0;
            loops = 0;
            powerOf10 = 10;
            for (i = 0; i < elem.Count; i++)
            {
                loops++;
                if (loops == 1)
                {
                    numOnTheStart += elem[i] * 1;
                    continue;
                }
                if (loops == 2)
                {
                    numOnTheStart += elem[i] * 10;
                    continue;
                }
                powerOf10 = powerOf10 * 10;

                numOnTheStart += elem[i] * powerOf10;
            }
            div = numOnTheStart - x5;
            if (div % 17 != 0)
            {
                return false;
            }

            //Console.WriteLine(number);
            //16
            loops = -1;
            nmod = 3;
            // n[3] n[2] n[1] n[0]
            //  ->4    3    2    <-1

            long[] n = new long[4];
            for (i = strint.Length - 1; i >= 0; i--)
            {
                loops++;
                if (loops > 3)
                {
                    break;
                }
                n[nmod] = (int)Char.GetNumericValue(strint[i]);
                nmod--;
            }

            check16 = n[3] + n[2] * 10 + n[1] * 100 + n[0] * 1000;

            if (check16 % 16 != 0)
            {
                return false;
            }



            //Console.WriteLine(number);
            //13
            int[] t = new int[3];
            List<int> eles = new List<int>();

            thirmod = 2;
            loops = -1; numOnTheBack = 0; numOnTheStart = 0;
            for (i = strint.Length - 1; i >= 0; i--)
            {
                loops++;

                if (loops < 3)
                {
                    t[thirmod] = (int)Char.GetNumericValue(strint[i]);
                    thirmod--;
                }
                else
                {
                    eles.Add((int)Char.GetNumericValue(strint[i]));
                }
            }
            numOnTheBack = t[2] + t[1] * 10 + t[0] * 100;
            powerOf10 = 10;
            loops = 0;
            for(i = 0 ; i < eles.Count; i++)
            {
                loops++;
                if(loops == 1)
                {
                    numOnTheStart += eles[i] * 1;
                    continue;
                }
                if(loops == 2)
                {
                    numOnTheStart += eles[i] * 10;
                    continue;
                }
                powerOf10 = powerOf10 * 10;

                numOnTheStart += eles[i] * powerOf10;
            }
            
            div = numOnTheBack - numOnTheStart;
            if (div % 13 != 0)
            {
                return false;
            }
            
            //Console.WriteLine(number);
            //11
            oddSum = 0; evenSum = 0;
            for (i = strint.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    evenSum += (int)Char.GetNumericValue(strint[i]);
                }
                else
                {
                    oddSum += (int)Char.GetNumericValue(strint[i]);
                }

                if (i == 0)
                {
                    if (oddSum - evenSum % 11 != 0)
                    {
                        return false;
                    }
                }
            }

            //Console.WriteLine(number);
            //7
            powerOf3 = 3;
            sum = 0;
            for (i = strint.Length - 1; i >= 0; i--)
            {
                if (i == strint.Length - 1)
                {
                    sum += (int)Char.GetNumericValue(strint[i]);
                    continue;
                }
                if (i == strint.Length - 2)
                {
                    sum += (int)Char.GetNumericValue(strint[i]) * 3;
                    continue;
                }

                powerOf3 = powerOf3 * 3;
                sum += (int)Char.GetNumericValue(strint[i]) * powerOf3;
            }

            if (sum % 7 != 0)
            {
                return false;
            }

            // Sum of numbers
            for (i = strint.Length - 1; i >= 0; i--)
            {
                sum += (int)Char.GetNumericValue(strint[i]);
            }

            //Console.WriteLine(number);
            //3 , 9
            if (sum % 3 != 0 || sum % 9 != 0)
            {
                return false;
            }

            Console.WriteLine(number);
            //4
            if (((int)Char.GetNumericValue(strint[strint.Length - 1]) + (int)Char.GetNumericValue(strint[strint.Length - 2]))  % 4 != 0)
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
