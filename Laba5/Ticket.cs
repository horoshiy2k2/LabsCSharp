using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5
{
    enum TicketType { Business, Economy, Comfort };
    class Ticket
    {
        public string Titel { get; set; }
        public int Price { get; set; }
        public TicketType Type { get; set; }

        public Ticket(string titel, int price, TicketType tt)
        {
            Titel = titel;
            Price = price;
            Type = tt;
        }
    }
}
