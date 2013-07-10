using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public static class Fabrica
    {
        public static Operation fabricaCalc(string arg1)
        {
            switch (arg1)
            {
                case "+": return new Add();
                case "-": return new Sub();
                case "*": return new Mul();
                case "/": return new Del();
                case "PowOp": return new PowOp();
                default: throw new Exception("Ошибка");
            }


        }
    }
}
