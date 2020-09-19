using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6
{
    class NoDiscount : IPrice
    {
        private double _price;
        public NoDiscount(double price)
        {
            _price = price;
        }
        public double GetPrice()
        {
            return _price;
        }
    }
}
