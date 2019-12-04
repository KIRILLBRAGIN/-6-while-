using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            string s = "";
            Console.WriteLine("Введите сиситему счисления (двоичная/восьмеричная/шестнадцатиричная)");
            int m = Convert.ToInt32(Console.ReadLine());
            if ((m == 2) || (m == 8))
            {


                while (n != 0)
                {
                    a = n % m;
                    n = n / m;
                    s = Convert.ToString(a) + s;
                }
                Console.WriteLine("число в системе счисления, указанной пользователем --> " + s);
                Console.ReadKey();
            }
            if (m == 16)
            {
                while (n != 0)
                {
                    a = n % m;
                    if (a == 10) { s = "A" + s; }
                    else if (a == 11) { s = "B" + s; }
                    else if (a == 12) { s = "C" + s; }
                    else if (a == 13) { s = "D" + s; }
                    else if (a == 14) { s = "E" + s; }
                    else if (a == 15) { s = "F" + s; }
                    else
                    {
                        a = n % m;
                        s = Convert.ToString(a) + s;
                    }
                    n = n / m;
                }
                Console.WriteLine("число в системе счисления, указанной пользователем --> "+s);
                Console.ReadKey();
            }
        }
    }
}
