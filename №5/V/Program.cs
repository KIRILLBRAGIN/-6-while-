using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = "Лось";
            string a = "Волк";
            string b = "волк";
            string c = "ВОЛК";
            while ((a != d) || (b != d) || (c != d))
            {
                Console.WriteLine("Не выступает в цирке.");
                d = Console.ReadLine();
                if ((a == d)||(b==d)||(c==d))
                {
                    Console.WriteLine("Правильно");
                    Console.ReadKey();
                }
                else { Console.WriteLine("Неправильно, подумай получше"); }
            }

            Console.ReadKey();
        }
    }
}
