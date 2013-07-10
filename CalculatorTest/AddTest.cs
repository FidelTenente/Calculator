using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    /// <summary>
    /// Сводное описание для AddTest
    /// </summary>
    [TestClass]
    public class AddTest
    {
       

        [TestMethod]
        public void TestSmallNumbers()
        {
            Add calc = new Add();
            double res = calc.Calculation(0, 1.01);
            double res1 = calc.Calculation(-1, -1.0);
            Assert.AreEqual(1, res, 0.1, "Error Add");
            Assert.AreEqual(-2, res1, 0.1, "Error Add");
            //
            // TODO: добавьте логику	теста
            //
        }
    }
}
