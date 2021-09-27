using _2._3.WildFarm.Animals;
using _2._3.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3.WildFarm
{
    public class Cat : Feline
    {
        private const double CatFoodPiece = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed):base(name, weight, livingRegion, breed)
        {

        }

        public override string MakeSound()
        {
            return "Meow";
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Meat")
            {
                Validator.GetValid(this.GetType().Name, food.GetType().Name);
                base.FoodEaten = 0;
                return;
            }
            base.FoodEaten = food.Quantity;
            this.Weight += food.Quantity * CatFoodPiece;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
