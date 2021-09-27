using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Shapes_LAB
{
    class Circle:Shapes
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                Validator.Valid(value, nameof(this.Radius));
                this.radius = value;
            }
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override string Draw()
        {
            return base.Draw() + " Circle";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Circle:").AppendLine($" - perimeter: {this.CalculatePerimeter():F2}").AppendLine($" - area: {this.CalculateArea():F2}").Append(this.Draw());
            return sb.ToString();
        }
    }
}
