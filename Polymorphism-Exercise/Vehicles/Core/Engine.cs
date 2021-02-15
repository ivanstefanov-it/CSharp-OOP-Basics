using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Vihicles;
using Vehicles.Vihicles.Contracts;

namespace Vehicles.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            IVehicle car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            IVehicle bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] input = Console.ReadLine().Split();

                    string actoin = input[0];
                    string vihicleType = input[1];
                    double value = double.Parse(input[2]);

                    if (actoin == "Refuel")
                    {
                        if (vihicleType == "Car")
                        {
                            car.Refuel(value);
                        }
                        else if (vihicleType == "Truck")
                        {
                            truck.Refuel(value);
                        }
                        else if (vihicleType == "Bus")
                        {
                            bus.Refuel(value);
                        }
                    }
                    else if (actoin == "Drive")
                    {
                        if (vihicleType == "Car")
                        {
                            car.Drive(value);
                        }
                        else if (vihicleType == "Truck")
                        {
                            truck.Drive(value);
                        }
                        else if (vihicleType == "Bus")
                        {
                            bus.IsVehicleEmpty = false;
                            bus.Drive(value);
                        }
                    }
                    else if (actoin == "DriveEmpty")
                    {
                        bus.IsVehicleEmpty = true;
                        bus.Drive(value);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
