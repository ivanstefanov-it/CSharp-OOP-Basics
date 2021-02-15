﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        protected Mammal(string name, double weight, string livingRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }
        
        public string LivingRegion
        {
            get { return livingRegion; }
            set { livingRegion = value; }
        }

        //public override string ToString()
        //{
        //    return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]"; 
        //}
    }
}
