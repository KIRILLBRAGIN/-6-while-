using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int p = 1;
            int k = 0;
            int b = 0;
            while (a!=0)
            { b=a%10;
            k++;
            sum+=b;
            p*=b;
            a = a/10;}
            Console.WriteLine("Количество цифр равно " + k);
            Console.WriteLine("Произведение цифр равно " + p);
            Console.WriteLine("Сумма цифр равна " + sum);
            Console.ReadKey(); }
    }
}
