using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число в двоичной системе счисления");
           long n = Convert.ToInt64(Console.ReadLine());
            double a = 0;
            int i = 0;
            while (n != 0)
            {
                if (n % 10 == 1)
                {
                    a = a + Math.Pow(2, i);
                }
                n = n / 10;
                i++;

            }
            Console.WriteLine("Число из двоичной системы счисления в десятичной --> " +a);
            Console.ReadKey();
        }
    }
}
