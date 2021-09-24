using System;

namespace _3.Shapes_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shapes circle = new Circle(5);
                Shapes rectangle = new Rectangle(5, 5);

                Console.WriteLine(circle);
                Console.WriteLine(rectangle);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
