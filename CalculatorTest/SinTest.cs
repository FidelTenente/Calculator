using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalculatorTest
{
    /// <summary>
    /// Сводное описание для SinTest
    /// </summary>
    [TestClass]
    public class SinTest
    {
        [TestMethod]
        public void TestSinNumbers()
        {
            Sin calc = new Sin();
            double res = calc.singleCalculation(9);
            double res1 = calc.singleCalculation(5);
            Assert.AreEqual(0.4121, res, 0.1, "Error Sin");
            Assert.AreEqual(-0.9589, res1, 0.001, "Error Sin");
            //
            // TODO: добавьте логику	теста
            //
        }
    }
}
