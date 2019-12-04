using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа");
            double sum = 0;
            double p = 1;
            double a=1;
            while (a != 0)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a != 0)
                {
                    sum = sum + a;
                    p = p * a;
                }
            }
            Console.WriteLine("Сумма равна " + sum);
            Console.WriteLine("Произведение равно " + p);
            Console.ReadKey();
        }
    }
}
