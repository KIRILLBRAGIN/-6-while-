using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапозон ");
            double sum = 0;
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            while (a <= b)
            {
                if ((a % 2 == 1) || (a % 2 == -1))
                {
                    sum = sum + a;
                    Console.WriteLine("Нечётное число "+a);
                }
                a++;
            }
            Console.WriteLine("Сумма нечётных = " + sum);
            Console.ReadKey();
        }
    }
}
