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
                case "sqrt": return new SqrtOp();
                default: throw new Exception("Ошибка");
            }
        }
    }
}
