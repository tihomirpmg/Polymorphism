using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2.VehiclesExtension
{
    class Validator
    {
        public static void CheckNumber(double value)
        {
            if (value < 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
        }
    }
}
