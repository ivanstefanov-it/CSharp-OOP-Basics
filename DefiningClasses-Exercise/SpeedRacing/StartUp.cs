using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);

                cars.Add(car);
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string model = command[1];
                string amountOfKm = command[2];
                Car currentCar = cars.Where(c => c.Model == model).FirstOrDefault();

                if (currentCar != null)
                {
                    currentCar.Drive(double.Parse(amountOfKm));
                }

                command = Console.ReadLine().Split();
            }

            Print(cars);
        }

        private static void Print(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTravelled}");
            }
        }
    }
}
