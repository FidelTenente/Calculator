using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Sin : singleOperation
    {
        public override double singleCalculation(double a)
        {
            return Math.Sin(a);

        }
    }
}
