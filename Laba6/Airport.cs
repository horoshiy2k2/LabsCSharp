using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6
{
    class Airport
    {
        List<Ticket> _lstTickets = new List<Ticket>();
        public void AddNoDiscountTicket(string name, double price)
        {
            Ticket ndt = new Ticket(name, new NoDiscount(price));
            _lstTickets.Add(ndt);
        }
        public void AddFixDiscountTicket(string name, double price, double discount)
        {
            Ticket dt = new Ticket(name, new FixDiscount(price, discount));
            _lstTickets.Add(dt);
        }
        public Ticket GetMostExpensiveTicket()
        { 
            double maxPrice = double.MinValue; // проерка на то, чтобы был хотя бы 1 тариф/направление/билет
            Ticket tempTicket = null;
            foreach (Ticket p in _lstTickets)
            {
                if (p.GetPrice() > maxPrice)
                {
                    maxPrice = p.GetPrice();
                    tempTicket = p;
                }
            }
            return tempTicket;
        }

        public void ShowAllTickets()
        {
            foreach (Ticket p in _lstTickets)
            {
                Console.WriteLine($"{p.Name}: {p.GetPrice():f2}");
            }
            Console.WriteLine();
        }

    }
}
