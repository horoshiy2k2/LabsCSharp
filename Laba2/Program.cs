using Laba2.Services;
using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine();
            Task2();
        }

        static void Task1()
        {
            Console.Write("Введите а: ");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());

            if (ClassF.F(a) > ClassF.F(b))      Console.WriteLine("Наименьше значение функция принимает в точке {0}", b);
            else if (ClassF.F(a) < ClassF.F(b)) Console.WriteLine("Наименьше значение функция принимает в точке {0}", a);
            else                                Console.WriteLine("Функция принимает одинаковые значения в точке {0} и в точке {1}", a, b);
        }

        static void Task2()
        {
            Console.WriteLine("Введите z: ");
            var z = double.Parse(Console.ReadLine());
            ClassV.F(z);
        }
    }
}
