using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public static class singleFabrica
    {
        public static singleOperation fabricaSingleCalc(string arg1)
        {
            switch (arg1)
            {
                case "Asin": return new Asin();
                case "Acos": return new Acos();
                case "Cos": return new Cos();
                case "Sin": return new Sin();
                case "Atan": return new Atan();
                case "Exp": return new Exp();
                case "Tan": return new Tan();
                case "sqrt": return new SqrtOp();
                case "Logarithm": return new Logarithm();
                case "1/X": return new Odin();
                default: throw new Exception("Ошибка");
            }
        }
    }
}
