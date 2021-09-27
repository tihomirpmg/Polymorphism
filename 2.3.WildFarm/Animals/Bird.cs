using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3.WildFarm.Animals
{
    public abstract class Bird : Animal
    {
        private double wingSize;

        protected Bird(string name, double weight, double wingSize):base(name, weight)
        {
            this.wingSize = wingSize;
        }

        public double WingSize
        {
            get { return this.wingSize; }
            set { this.wingSize = value; }
        }
    }
}
