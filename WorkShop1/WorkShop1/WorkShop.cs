using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop1
{
    internal class PrimeNumber
    {
        public static void PrimeFactor()
        {
            int n = 0;
            int temp = 0;

            Console.WriteLine("Enter the number to check prime");
            n = Convert.ToInt32(Console.ReadLine());
            int m = n / 2;

            for (int i = 2; i < m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Entered number is NOT Prime");
                    temp = 1;
                    break;

                }


            }
            if (temp == 0)
            {
                Console.WriteLine("Enter Number is Prime");

            }

        }
    }
}
