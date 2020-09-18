using System;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport minsk = new Airport();
            minsk.AddTicket("Minsk-Brest B", 20, TicketType.Business); // с одним и тем же именем будут разные типы билетов, реализовать... поиск
            minsk.AddTicket("Minsk-Brest E", 8, TicketType.Economy); 
            minsk.AddTicket("Minsk-Brest C", 12, TicketType.Comfort); 
            minsk.AddTicket("Minsk-Vitebsk C", 10, TicketType.Comfort);
            minsk.AddTicket("Minsk-Mogilev B", 15, TicketType.Business);
            minsk.AddTicket("Minsk-Zaslavl E", 2, TicketType.Economy);

            minsk.AddCustomer("Fomina Maria Ostapovna", "AB1234567");
            minsk.AddCustomer("Ivanov Ivan Ivanovich", "AB9876543");

            minsk.LogIn("Ivanov Ivan Ivanovich");
            minsk.BuyTicket("Minsk-Brest B");
            minsk.BuyTicket("Minsk-Mogilev B");
            minsk.BuyTicket("Minsk-Brest C");

            minsk.LogOut();

            minsk.LogIn("Fomina Maria Ostapovna");
            minsk.BuyTicket("Minsk-Zaslavl E");
            minsk.BuyTicket("Minsk-Zaslavl E");
            minsk.BuyTicket("Minsk-Zaslavl E");
            minsk.BuyTicket("Minsk-Brest E");
            minsk.LogOut();

            Console.WriteLine($"Суммарная стоимость всех купленных клиентами билетов: {minsk.GetTotalSum()}\n");
            Console.WriteLine(minsk.GetTicketsByName("Ivanov Ivan Ivanovich"));
            Console.WriteLine(minsk.GetTicketsByName("Fomina Maria Ostapovna"));
        }
    }
}

//4.Предметная область: Аэропорт.
//Касса аэропорта имеет список тарифов на различные направления.  
//При покупке билета регистрируются паспортные данные.   

//Система должна:  
//  позволять вводить данные о тарифах;  
//  позволять вводить паспортные данные пассажира и 
//регистрировать покупку билета;  
//  рассчитывать стоимость купленных пассажиром билетов;  
//  рассчитывать стоимость всех проданных билетов.

//Задание к работе  
//  Для  заданной  предметной  области  спроектировать  программную 
//структуру, состоящую из 3-5 классов. 
//  В  соответствии  с  разработанной  диаграммой  классов  выполнить 
//программную реализацию. 
//  Предусмотреть использование типа данных – перечисление.  ENUM
//  Ввод/вывод должен быть реализован вне проектируемого класса.   