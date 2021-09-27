using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Shapes_LAB
{
    class Validator
    {
        public static void Valid(double value, string dimension)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{dimension} cannot be zero or negative number!");
            }
        }
    }
}
