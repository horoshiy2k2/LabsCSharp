using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5
{
    class Airport //тот же синглтон
    {
        /// <summary> 
        /// Список билетов 
        /// </summary> 
        private List<Ticket> _lstTickets = new List<Ticket>();

        /// <summary> 
        /// Список клиентов 
        /// </summary> 
        private List<Customer> _lstCust = new List<Customer>();

        private Customer _currentCust; // текущий клиент 

        /// <summary> 
        /// Добавить тариф(стоимость конкретного билета) 
        /// </summary> 
        /// <param name="t">название</param> 
        /// <param name="p">цена</param> 
        /// <param name="tt">тип билета</param> 
        public void AddTicket(string t, int p, TicketType tt)
        {
            _lstTickets.Add(new Ticket(t, p, tt));
        }

        /// <summary> 
        /// Добавить клиента 
        /// </summary> 
        /// <param name="n">Имя</param> 
        /// <param name="p">Данные паспорта</param> 
        public void AddCustomer(string n, string p)
        {
            _lstCust.Add(new Customer(n, p));
        }

        /// <summary> 
        /// Найти клиента по имени 
        /// </summary> 
        /// <param name="n">Имя</param> 
        /// <returns></returns> 
        Customer GetCustByName(string n) // только внутри можно вызвать...
        {
            foreach (Customer item in _lstCust)
            {
                if (item.Name == n) return item;
            }
            return null;
        }

        /// <summary> 
        /// Найти товар по названию 
        /// </summary> 
        /// <param name="t">название товара</param> 
        /// <returns></returns> 
        Ticket GetTicketByTitle(string t)
        {
            foreach (Ticket item in _lstTickets)
            {
                if (item.Titel == t) return item;
            }
            return null;
        }

        /// <summary> 
        /// Регистрация в системе 
        /// </summary> 
        /// <param name="n">Имя клиента</param> 
        public void LogIn(string n)
        {
            if (_currentCust == null)
                _currentCust = GetCustByName(n);
        }

        /// <summary> 
        /// Выход из системы 
        /// </summary> 
        public void LogOut()
        {
            _currentCust = null;
        }

        /// <summary> 
        /// Копить билет для текущего клиента 
        /// </summary> 
        /// <param name="titel">название товара</param> 
        public void BuyTicket(string titel)
        {
            Ticket p = GetTicketByTitle(titel);
            _currentCust.BuyTicket(p);
        }

        /// <summary> 
        /// Получить общую сумму купленных билетов 
        /// </summary> 
        /// <returns></returns> 
        public int GetTotalSum()
        {
            int sum = 0;
            int currentSum;
            foreach (Customer c in _lstCust)
            {
                currentSum = 0;
                foreach (Ticket p in c.LstTicketsOfCust)
                {
                    sum += p.Price;
                    currentSum += p.Price;
                }
                Console.WriteLine($"Суммарная стоимость билетов клиента {c.Name}: {currentSum}");
            }
            return sum;
        }

        /// <summary> 
        /// Получить список билетов, купленных клиентом 
        /// </summary> 
        /// <param name="name">имя клиента</param> 
        /// <returns></returns> 
        public string GetTicketsByName(string name)
        {
            var c = GetCustByName(name);
            var s = $"Customer: {c.Name}\n";
            foreach (Ticket t in c.LstTicketsOfCust)
            {
                s += $"{t.Titel} {t.Price} {t.Type}\n";
            }
            return s;
        }
    }
}
