using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> listOfEngine = new List<Engine>();
            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                Engine engine = new Engine(model, power);

                if (input.Length == 3)
                {
                    int displacement;

                    if (int.TryParse(input[2], out displacement))
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        engine.Efficiency = input[2];
                    }
                }
                else if (input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];
                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency;
                }

                listOfEngine.Add(engine);
            }

            var m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engineModel = input[1];
                Engine engine = listOfEngine.FirstOrDefault(e => e.Model == engineModel);
                Car car = new Car(model, engine);

                if (input.Length == 3)
                {
                    int weight;

                    if (int.TryParse(input[2], out weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = input[2];
                    }
                }
                else if (input.Length == 4)
                {
                    int weight = int.Parse(input[2]);
                    string color = input[3];
                    car.Weight = weight;
                    car.Color = color;
                }

                listOfCars.Add(car);
            }

            foreach (var car in listOfCars)
            {
                PrintCarModelEngineAndEngineProperties(car);
                PrintCarWeightAndColor(car);
            }
        }

        private static void PrintCarWeightAndColor(Car car)
        {
            if (car.Weight == 0)
            {
                Console.WriteLine($"  Weight: n/a");
            }
            else
            {
                Console.WriteLine($"  Weight: {car.Weight}");
            }

            if (car.Color == null)
            {
                Console.WriteLine($"  Color: n/a");
            }
            else
            {
                Console.WriteLine($"  Color: {car.Color}");
            }
        }

        private static void PrintCarModelEngineAndEngineProperties(Car car)
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine.Model}:");
            Console.WriteLine($"    Power: {car.Engine.EnginePower}");
            if (car.Engine.Displacement == 0)
            {
                Console.WriteLine($"    Displacement: n/a");
            }
            else
            {
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
            }
            if (car.Engine.Efficiency == null)
            {
                Console.WriteLine($"    Efficiency: n/a");
            }
            else
            {
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
            }
        }
    }
}
