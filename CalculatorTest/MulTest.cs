using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    /// <summary>
    /// Сводное описание для MulTest
    /// </summary>
    [TestClass]
    public class MulTest
    {
       

        [TestMethod]
        public void TestMul()
        {
            Mul calc4 = new Mul();
            double res = calc4.Calculation(12, 5);
            double res1 = calc4.Calculation(-125, 55.235);
            Assert.AreEqual(60, res, 0.1, "Error Mul");
            Assert.AreEqual(-6904.375, res1, 0.001, "Error Mul");
            //
            // TODO: добавьте логику	теста
            //
        }
    }
}
