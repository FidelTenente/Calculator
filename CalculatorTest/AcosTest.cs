using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalculatorTest
{
    /// <summary>
    /// Сводное описание для AcosTest
    /// </summary>
    [TestClass]
    public class AcosTest
    {
        [TestMethod]
        public void TestAcosNumbers()
        {
            Acos calc = new Acos();
            double res = calc.singleCalculation(2);
            double res1 = calc.singleCalculation(7);
            Assert.AreEqual(1.3169, res, 0.1, "Error Acos");
            Assert.AreEqual(2.6339, res1, 0.0001, "Error Acos");
            //
            // TODO: добавьте логику	теста
            //
        }
    }
}
