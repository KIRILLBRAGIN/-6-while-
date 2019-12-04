using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            while (n != 0)
            {
                a = n % 10 + a * 10;
                n = n / 10;
            }
            Console.WriteLine("Перевёрнутое число --> "+ a);
            Console.ReadKey();
        }
    }
}
