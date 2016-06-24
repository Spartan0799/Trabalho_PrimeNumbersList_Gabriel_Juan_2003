using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_PrimeNumbersList_Gabriel_Juan_2003
{
    class List
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;

            for (int i = 1; i <= a; i++)
            {
                for (int primas = 2; primas <= a; primas++)
                {

                    if (i != primas && i % primas == 0)
                    {
                        isPrime = false;

                        break;
                    }


                }

                if (isPrime)
                {
                    Console.WriteLine(+ i);
                }

                isPrime = true;
            }

            Console.ReadLine();
        }
    }
}

