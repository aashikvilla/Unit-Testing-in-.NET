using System;
using app;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace app_test
{
    [TestClass]
    public class CalculatorTest
    {
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public void Add(int value)
        {
            Console.WriteLine("Testing {0} + {0}", value);
            var actual = Calculator.Add(value, value);
            var expected = value + value;
            Assert.AreEqual(actual, expected);
        }

        [DataTestMethod]
        [DataRow(3,1)]
        public void Subtract(int v1,int v2)
        {
          
            Console.WriteLine("Testing {0} - {1}");
            var actual = Calculator.Subtract(v1, v2);
            var expected = v1 - v2-100;
            Console.WriteLine("aaaaaaaaa", v1, v2);
            Assert.AreEqual(actual, expected);

        }

        //[TestMethod]
        //[TestCategory("DivideAndMultiply")]
        //public void Divide()
        //{
        //    Assert.AreEqual(1, 1);
        //}

        //[TestMethod]
        //[TestCategory("DivideAndMultiply")]
        //public void Multiply()
        //{
        //    Assert.AreEqual(1, 1);
        //}
    }
}
