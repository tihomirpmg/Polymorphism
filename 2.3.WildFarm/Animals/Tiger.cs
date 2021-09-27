using _2._3.WildFarm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3.WildFarm.Animals
{
    public class Tiger : Feline
    {
        private const double TigerFoodPiece = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed):base(name, weight, livingRegion, breed)
        {

        }

        public override string MakeSound()
        {
            return "ROAR!!!";
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
            this.Weight += food.Quantity * TigerFoodPiece;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
