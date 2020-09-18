using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5
{

    class Customer
    {
        // список купленных билетов
        List<Ticket> _lstTicketsOfCust = new List<Ticket>();
        public List<Ticket> LstTicketsOfCust
        {
            get { return _lstTicketsOfCust; }
        }

        public string Passport { get; set; } 
        public string Name { get; set; }
        public Customer(string n, string p)
        {
            Name = n; 
            Passport = p;
        }

        /// <summary> 
        /// Купить билет 
        /// </summary> 
        /// <param name="p"></param> 
        public void BuyTicket(Ticket p)
        {
            _lstTicketsOfCust.Add(p);
        }

        /// <summary> 
        /// Получить стоимость всех купленных пассажиром билетов 
        /// </summary> 
        /// <returns></returns> 
        public int GetSum()
        {
            int s = 0;
            foreach (Ticket item in _lstTicketsOfCust)
            {
                s += item.Price;
            }
            return s;
        }
    }
}
