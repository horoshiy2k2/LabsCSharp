using System;

namespace Laba3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var bank1 = new Bank();
            bank1.Show();

            bank1.Name = "BelinvestBank";
            bank1.Vklad = 50000;
            bank1.KolYears = 1;
            bank1.KolVkladov = 1; // можем установить, но не прочитать
            //bank1.Percent = 10; // выдаст ошибку из-за private set
            //Console.WriteLine(bank1.Name); // выдаст ошибку, из-за отсутствия аксессора get
            
            bank1.Show();

            var bank2 = new Bank("Alpha-Bank");
            bank2.Show();



        }
    }
    class Bank
    {
        private string _name;
        public decimal Vklad { get; set; }
        public int KolVkladov { private get; set; } // вне класса только для записи
        public int Percent { get; private set; } // вне класса только для чтения
        public int KolYears { get; set; }

        public string Name // только для записи
        {
            set
            {
                _name = value;
            }
        }

        public Bank() // конструктор 1
        {
            Name = "Unknown Bank";
            Vklad = 100000;
            KolVkladov = 2;
            Percent = 15;
            KolYears = 10;
        }

        public Bank(string s) // конструктор 2 (для рандомного создания банка)
        {
            var rand = new Random();
            Name = s;
            Vklad = (decimal)rand.NextDouble() * 100000; // от 0.0 до 1.0
            KolVkladov = rand.Next(1, 11);
            Percent = rand.Next(5, 26);
            KolYears = rand.Next(1, 21);
        }

        public decimal TotalPayment()
        {
            return KolVkladov * Vklad * Percent / 100 * KolYears;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {_name}\nVklad: {Vklad}\nKolVkladov: {KolVkladov}\nPercent: {Percent}\nKolYears: {KolYears}\nTotal payment: {TotalPayment()}\n");
        }
    }
}

//            Задание к работе
//  Выбрать предметную область согласно варианту индивидуального
//задания.
//  Спроектировать класс для выбранной предметной области. 
//  Нарисовать диаграмму спроектированного класса. 
//  Предусмотреть наличие у объекта полей, методов и свойств.
//  Предусмотреть наличие свойств только для записи. 

//            24.Предметная  область: Банк.В классе  хранить информацию  о
//наименовании банка, число вкладов, размер вклада(все вклады одинаковые), 
//размер процентной ставки.Реализовать метод для подсчета общей выплаты по
//процентам.