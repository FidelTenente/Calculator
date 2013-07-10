using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Tan : singleOperation
    {
        public override double singleCalculation(double a)
        {
            return Math.Tan(a);

        }
    }
}
