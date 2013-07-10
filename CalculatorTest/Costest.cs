using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    /// <summary>
    /// Сводное описание для Costest
    /// </summary>
    [TestClass]
    public class Costest
    {
        [TestMethod]
        public void TestCosNumbers()
        {
            Cos calc = new Cos();
            double res = calc.singleCalculation(0);
            double res1 = calc.singleCalculation(1);
            Assert.AreEqual(1, res, 0.1, "Error Cos");
            Assert.AreEqual(0.5403, res1, 0.0001, "Error Cos");
            //
            // TODO: добавьте логику	теста
            //
        }
    }
}
