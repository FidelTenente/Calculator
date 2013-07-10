using System;
using System.Text;
using System.Collections.Generic;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    /// <summary>
    /// Сводное описание для AsinTest
    /// </summary>
    [TestClass]
    public class AsinTest
    {
        [TestMethod]
        public void TestAsinNumbers()
        {
            Asin calc = new Asin();
            double res = calc.singleCalculation(1);
            double res1 = calc.singleCalculation(0);
            Assert.AreEqual(1.5707, res, 0.1, "Error Asin");
            Assert.AreEqual(0, res1, 0.0001, "Error Asin");
            //
            // TODO: добавьте логику	теста
            //
        }
    }
}
