using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalculatorTest
{
    /// <summary>
    /// Сводное описание для OdinTest
    /// </summary>
    [TestClass]
    public class OdinTest
    {
         

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestWithZero()
        {Odin calc=new Odin();
            double res =calc.singleCalculation(0);
            Assert.IsTrue(Double.IsInfinity(res),"Error 1/x");
        }
        [TestMethod]
        public void TestWithTwo()
        {
            Odin calc = new Odin();
            double res1 = calc.singleCalculation(2);
            Assert.AreEqual(0.5,res1,0.1,"Error with two");
        }
    }
}
