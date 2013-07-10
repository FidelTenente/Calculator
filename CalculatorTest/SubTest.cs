using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    /// <summary>
    /// Сводное описание для SubTest
    /// </summary>
    [TestClass]
    public class SubTest
    {
        
        
           
        [TestMethod]
        public void TestSub()
        {
            Sub calc3 = new Sub();
            double res = calc3.Calculation(45, 5.5);
            double res1 = calc3.Calculation(-125.25, -13.045);
            Assert.AreEqual(39.5, res, 0.1, "Error Sub");
            Assert.AreEqual(-112.205, res1, 0.001, "Error Sub");
            //
            // TODO: добавьте логику	теста
            //
        }
    }
}
