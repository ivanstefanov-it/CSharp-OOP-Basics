﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Vihicles
{
    public class Bus : Vehicle
    {
        private const double airConditionConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            double currentFuelConsumption = this.FuelConsumption;

            if (IsVehicleEmpty == false)
            {
                currentFuelConsumption += airConditionConsumption;
            }

            double neededFuel = distance * currentFuelConsumption;

            if (this.FuelQuantity < neededFuel)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= neededFuel;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }
}
