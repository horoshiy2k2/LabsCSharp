using System;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine();
            Task2();
            Console.WriteLine();
            TaskDop1();
            Console.WriteLine();
            TaskDop2();
        }

        //Оканчивается ли число на 7
        static void Task1()
        {
            Console.Write("Введите число: ");
            Console.WriteLine(int.Parse(Console.ReadLine()) % 10 == 7 ? "Да, последняя цифра - 7" : "Нет, последняя цифра не 7");
        }

        //Где находится точка, относительно заданной области
        static void Task2()
        {
            Console.Write("Введите x: ");
            var x = float.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            var y = float.Parse(Console.ReadLine());
            var r1 = 5;
            var r2 = 10;

            if (x * x + y * y < r2 * r2 && x * x + y * y > r1 * r1 && y > 0) Console.WriteLine("Внутри");
            else if ((x * x + y * y == r2 * r2 || x * x + y * y == r1 * r1) && y >= 0) Console.WriteLine("На границе");
            else Console.WriteLine("Вне");
        }

        //Задача 1. Задана дата в формате <день>.<месяц>.<год>. Определить: 
        //1.  сколько дней прошло с начала года; 
        //2.  сколько дней осталось до конца года; 
        //3.  дату предыдущего дня; 
        //4.  дату следующего дня.
        static void TaskDop1()
        {
            Console.WriteLine("Введите дату в формате <день>.<месяц>.<год>");
            var strDate = Console.ReadLine();
            string[] arrDMY = strDate.Split(new char[] { '.' });

            int day = int.Parse(arrDMY[0]);
            int month = int.Parse(arrDMY[1]);
            int year = int.Parse(arrDMY[2]);

            var date1 = new DateTime(year, month, day);
            var dateEndYear = new DateTime(year, 12, 31); // конец года - 31 декабря

            // Считаем интервал между двумя датами
            TimeSpan interval2 = dateEndYear - date1; // можно было бы и обойтись 365 - текущий день, но может быть високосный год

            Console.WriteLine($"Количество дней с начала года: {date1.DayOfYear}");
            Console.WriteLine($"Количество дней до конца года: {interval2.Days}");
            Console.WriteLine($"Дата предыдущего дня: {date1.AddDays(-1).ToShortDateString()}");
            Console.WriteLine($"Дата следующего дня: {date1.AddDays(1).ToShortDateString()}");
        }

        //найти все трёхзначные числа Армстронга
        static void TaskDop2()
        {
            Console.WriteLine("Все трёхзначные числа Армстронга:");
            var n = 3;

            for (int i = 100; i < 1000; i++)
            {
                var c1 = i % 10;
                var c2 = i % 100 / 10;
                var c3 = i / 100;
                if (Math.Pow(c1, n) + Math.Pow(c2, n) + Math.Pow(c3, n) == i) Console.WriteLine(i);
            }

        }

    }
}
