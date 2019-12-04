using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VI
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            Console.WriteLine("Введите число n");
            double n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Число разложенное на простые множители");
            while (n > 0)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                    n = n / i * 1.0;
                }
                else { i++; }
            }
            Console.ReadKey();
        }
    }
}
