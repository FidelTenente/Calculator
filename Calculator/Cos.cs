using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Cos : singleOperation
    {
        public override double singleCalculation(double a)
        {
            return Math.Cos(a);

        }
    }
}
