﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Shapes_LAB
{
    class Rectangle:Shapes
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                Validator.Valid(value, nameof(this.Width));
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                Validator.Valid(value, nameof(this.Height));
                this.height = value;
            }
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.Width + 2 * this.Height;
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override string Draw()
        {
            return base.Draw() + " Rectangle";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rectangle:").AppendLine($" - perimeter: {this.CalculatePerimeter():F2}").AppendLine($" - area: {this.CalculateArea():F2}").Append(this.Draw());
            return sb.ToString();
        }
    }
}
