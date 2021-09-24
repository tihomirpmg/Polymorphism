using System;

namespace _2._1.Vehicles
{
    class Program
    {
        private static Car car;
        private static Truck truck;

        public static void Main()
        {
            ParseInput();
            int numberOfCommands = int.Parse(Console.ReadLine());
            ParseCommand(numberOfCommands);
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ParseCommand(int numberOfCommands)
        {
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] comParts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = comParts[0];
                switch (command)
                {
                    case "Drive":
                        DriveCommand(comParts);
                        break;
                    case "Refuel":
                        RefuelCommand(comParts);
                        break;
                }
            }
        }
        private static void ParseInput()
        {
            string[] carParts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] truckParts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            car = new Car(double.Parse(carParts[1]), double.Parse(carParts[2]));
            truck = new Truck(double.Parse(truckParts[1]), double.Parse(truckParts[2]));
        }

        
        private static void DriveCommand(string[] comParts)
        {
            string vehicle = comParts[1];
            switch (vehicle)
            {
                case "Car":
                    car.Drive(double.Parse(comParts[2]));
                    break;
                case "Truck":
                    truck.Drive(double.Parse(comParts[2]));
                    break;
            }
        }
        private static void RefuelCommand(string[] comParts)
        {
            string vehicle = comParts[1];
            switch (vehicle)
            {
                case "Car":
                    car.Refuel(double.Parse(comParts[2]));
                    break;
                case "Truck":
                    truck.Refuel(double.Parse(comParts[2]));
                    break;
            }
        }

    }
}
