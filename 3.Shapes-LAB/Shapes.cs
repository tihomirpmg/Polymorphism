using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Shapes_LAB
{
    public abstract class Shapes
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return "Drawing";
        }
    }
}
