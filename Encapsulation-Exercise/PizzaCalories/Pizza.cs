using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.Toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value == string.Empty || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            private get
            {
                return this.dough;
            }

            set
            {
                this.dough = value;
            }
        }

        public List<Topping> Toppings
        {
            get
            {
                return this.toppings;
            }
            set
            {
                this.toppings = value;
            }
        }

        public int GetNumberOfToppings()
        {
            return this.Toppings.Count;
        }

        public void AddTopping(Topping topping)
        {
            if (this.Toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.Toppings.Add(topping);
        }

        public double Callories()
        {
            double callories = 0;
            callories += this.dough.Callories();
            foreach (Topping topping in this.Toppings)
            {
                callories += topping.Callories();
            }

            return callories;
        }
    }
}