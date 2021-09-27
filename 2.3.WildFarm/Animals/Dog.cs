using _2._3.WildFarm.Animals;
using _2._3.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3.WildFarm
{
    public class Dog : Mammal
    {
        private const double DogFoodPiece = 0.40;

        public Dog(string name, double weight, string livingRegion):base(name, weight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "Woof!";
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                Validator.GetValid(this.GetType().Name, food.GetType().Name);
                base.FoodEaten = 0;
                return;
            }
            base.FoodEaten = food.Quantity;
            this.Weight += food.Quantity * DogFoodPiece;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
