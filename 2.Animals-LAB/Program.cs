using System;

namespace _2.Animals_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Tom", "Whiskas");
            Animal dog = new Dog("Djeri", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
