using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    /// <summary>
    /// Сводное описание для DelTest
    /// </summary>
    [TestClass]
    public class DelTest
    {
      
        [TestMethod]
        public void TestDel()
        {
            Del calc2 = new Del();
            double res2 = calc2.Calculation(10, 5);
            double res3 = calc2.Calculation(-65, 20.5);
            Assert.AreEqual(2, res2, 0.1, "Error Del");
            Assert.AreEqual(-3.170, res3, 0.001, "Error Del");
            
            //
            // TODO: добавьте логику	теста
            //
        }
    }
}
