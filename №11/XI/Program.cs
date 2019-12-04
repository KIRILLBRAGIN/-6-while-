using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число из двоичной сиситемы счисления");
            int n = Convert.ToInt32(Console.ReadLine());
            double a = 0;
            string o8 = "";
            int m = 8;
            int v = 16;
            string s = "";
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
            int g = Convert.ToInt32(a);
            int j = Convert.ToInt32(a);
            if ((m == 8))
            {
                while (j != 0)
                {
                    a = j % m;
                    j = j / m;
                    o8 = Convert.ToString(a) + o8;
                }
            }
            if (v == 16)
            {
                while (g != 0)
                {
                    a = g % v;
                    if (a == 10) { s = "A" + s; }
                    else if (a == 11) { s = "B" + s; }
                    else if (a == 12) { s = "C" + s; }
                    else if (a == 13) { s = "D" + s; }
                    else if (a == 14) { s = "E" + s; }
                    else if (a == 15) { s = "F" + s; }
                    else
                    {
                        a = g % v;
                        s = Convert.ToString(a) + s;
                    }
                    g = g / v;
                }
                Console.WriteLine("В восьмеричной  = " + o8);
                Console.WriteLine("В шестнадцатиричной = " + s);
                Console.ReadKey();
            }
        }
    }
}
