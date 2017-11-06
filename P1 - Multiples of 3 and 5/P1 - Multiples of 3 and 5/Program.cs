using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1___Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int pool = 0;
            int i;
            for(i = 1; i<1000; i++)
            {
                if(i%3 == 0 || i%5 == 0)
                {
                    pool += i;
                }
            }

            Console.WriteLine(pool);
            Console.ReadKey();
        }
    }
}
