﻿using Cars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Cars
{
    public class Seat : Car , ICar
    {
        public Seat(string model, string color) : base(model, color)
        {
        }
    }
}
