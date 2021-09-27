using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3.WildFarm
{
    public class Validator
    {
        public static void GetValid(string type, string foodType)
        {
            Console.WriteLine($"{type} does not eat {foodType}!");
        }
    }
}
