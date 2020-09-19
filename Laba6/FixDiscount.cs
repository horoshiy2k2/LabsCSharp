using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6
{
    class FixDiscount : IPrice
    {
        private double _price;
        private double _discount;
        public FixDiscount(double price, double discount)
        {
            _price = price;
            _discount = discount;
        }
        public double GetPrice() // наследует метод GetPrice() - обязательная реализация
        {
            return _price * (1 - _discount / 100); // процентная скидка
        }
    }
}
