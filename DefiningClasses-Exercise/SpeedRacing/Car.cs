using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelConsumption;
        private double fuelAmount;
        private double distanceTravelled;


        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.DistanceTravelled = 0.0;
        }
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        
        public double DistanceTravelled
        {
            get { return distanceTravelled; }
            set { distanceTravelled = value; }
        }

        public void Drive(double kilometers)
        {
            double neededFuel = kilometers * this.fuelConsumption;

            if (this.fuelAmount < neededFuel)
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
                return;
            }

            this.fuelAmount -= neededFuel;
            this.distanceTravelled += kilometers;
        }
    }
}
