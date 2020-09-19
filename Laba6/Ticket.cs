using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6
{
    class Ticket //тарифы, направления
    {
        private IPrice _ip;
        public string Name { get; set; }

        public Ticket(string name, IPrice ip) // ip хранит ссылку на экземпляр интерфейса Ipice, то есть на экземпляр любого НАСЛЕДУЕМОГО класса
        {
            Name = name;
            _ip = ip; // интерфейсная ссылка
        }
        
        public double GetPrice() // удобно с интерфейсом, т.к. иначе бы пришлось создавать 2 конструктора для 2ух билетов: с и без скидки, а если их 100...
        {
            return _ip.GetPrice(); // Вызов метода интерфейса через интерфейсную ссылку
        }
    }
}
