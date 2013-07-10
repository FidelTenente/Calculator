using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class PowOp:Operation
    {
        public override double Calculation(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
