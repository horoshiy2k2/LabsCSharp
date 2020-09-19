using System;

namespace Laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport minsk = new Airport();
            minsk.AddFixDiscountTicket("Minsk - Moscow", 100, 20); // скидка в процентах
            minsk.AddFixDiscountTicket("Minsk - Vilnius", 110, 11);
            minsk.AddFixDiscountTicket("Minsk - Stambul", 200, 50);
            minsk.AddFixDiscountTicket("Minsk - Amsterdam", 300, 77.7);
            minsk.AddNoDiscountTicket("Minsk - Kiev", 80);
            minsk.AddNoDiscountTicket("Minsk - Kishinev", 140);

            minsk.ShowAllTickets();
            Console.WriteLine("Самое дорогое направление: {0}\nЕго стоимость: {1}",
                minsk.GetMostExpensiveTicket().Name, minsk.GetMostExpensiveTicket().GetPrice());


        }
    }
}

//Задание к работе  
//  Составить диаграмму классов проектируемой системы.  -
//  Запрограммировать классы в соответствии с новой диаграммой.   +
//  Проиллюстрировать использование интерфейсов.  +
//  Показать вызов метода интерфейса через интерфейсную ссылку.  +
//  Применить в программе шаблон проектирования Strategy ?

//4.Предметная область: Аэропорт. Касса аэропорта имеет список тарифов 
//на различные  направления.  Тариф  содержит  название  направления  и 
//стоимость  перевозки.  На  некоторые  направления  предоставляется 
//фиксированная  скидка.  В  классе  аэропорт  реализовать  метод  добавления 
//нового тарифа и метод поиска направления с максимальной стоимостью. +

//Почитать про Strategy ?
