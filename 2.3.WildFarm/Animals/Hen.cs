using _2._3.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3.WildFarm.Animals
{
    public class Hen : Bird
    {
        private const double HenFoodPiece = 0.35;

        public Hen(string name, double weight, double wingSize):base(name, weight, wingSize)
        {
        }

        public override string MakeSound()
        {
            return "Cluck";
        }

        public override void Eat(Food food)
        {
            base.FoodEaten = food.Quantity;
            this.Weight += food.Quantity * HenFoodPiece;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {base.FoodEaten}]";
        }
    }
}
