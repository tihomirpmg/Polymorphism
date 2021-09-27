using _2._3.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3.WildFarm.Animals
{
    public abstract class Animal
    {
        private string name;
        private double weight;
        private int foodEaten;

        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public abstract string MakeSound();

        public abstract void Eat(Food food);
    }
}
