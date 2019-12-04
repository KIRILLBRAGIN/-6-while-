using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            string s = "";
            while (n != 0)
            {
                a = n % 2;
                n = n / 2;
                s = Convert.ToString(a) + s;
            }
            Console.WriteLine("В двоичном виде");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
