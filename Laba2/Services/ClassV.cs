using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2.Services
{
    class ClassV
    {
        internal static void F(double z)
        {
            double x;
            if (z < 1)
            {
                Console.WriteLine("Ветка 1: x = z^3 + 0.2");
                x = Math.Pow(z, 3) + 0.2;
            }
            else
            {
                Console.WriteLine("Ветка 2: x = z + ln(z)");
                x = z + Math.Log(z);
            }

            double y = Math.Pow(Math.Cos(x * x), 3) + Math.Pow(Math.Sin(Math.Pow(x, 3)), 2);
            Console.WriteLine("y = {0}", y);
        }
    }
}
