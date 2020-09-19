using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6
{
    interface IPrice // Не может содержать полей и свойств, только методы для реализации в наследниках
    {
        double GetPrice();
    }
}
