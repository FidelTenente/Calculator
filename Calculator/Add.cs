﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
   public class Add:Operation
   {
       public override double Calculation(double a, double b)
       {
           return a + b;      
       }
    }
}
