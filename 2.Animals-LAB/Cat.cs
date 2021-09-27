﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Animals_LAB
{
    class Cat:Animal
    {
        public Cat(string name, string favouriteFood):base(name, favouriteFood)
        {

        }
        public override string ExplainSelf()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExplainSelf()).Append("MEEOW");
            return sb.ToString();
        }
    }
}
