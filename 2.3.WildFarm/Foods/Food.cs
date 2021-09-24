using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3.WildFarm.Foods
{
    public abstract class Food
    {
        private int quantity;

        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
    }
}
