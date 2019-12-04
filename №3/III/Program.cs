using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа");
            double sum = 0;
            double p = 1;
            double b = 0;
            double a = 1;
            while (a != 0)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a != 0)
                {
                    sum = sum + a;
                    b++;
                    p = sum/b*1.0;
                }
            }
            Console.WriteLine("Сумма равна: " + sum);
            Console.WriteLine("Среднее арифметическое равно: " + p);
            Console.WriteLine("Количество чисел: " + b);
            Console.ReadKey();
        }
    }
}
