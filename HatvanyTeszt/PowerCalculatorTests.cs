using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HatvanyTeszt
{
    [TestClass]
    public class PowerCalculatorTests
    {
        [TestMethod]
        public void TestPositiveExponent()
        {
            double eredmeny = new PowerCalculator();
            double a = 2;
            double b = 3;
            
            
            

            Assert.AreEqual(8, eredmeny);

        }
        [TestMethod]
        public void TestZeroExponent()
        {
            double eredmeny = new PowerCalculator();
            double a = 5;
            double b = 0;
            



            Assert.AreEqual(1, eredmeny);

        }
        [TestMethod]
        public void TestNegativeExponent()
        {
            double eredmeny = new PowerCalculator();
            double a = 2;
            double b = -2;
            



            Assert.AreEqual(0.25, eredmeny);

        }
        [TestMethod]
        public void TestZeroBasePositiveExponent()
        {
            double eredmeny = new PowerCalculator();
            double a = 0;
            double b = 5;
            



            Assert.AreEqual(0, eredmeny);

        }
        [TestMethod]
        public void TestZeroBaseZeroExponent()
        {
            double eredmeny = new PowerCalculator();
            double a = 0;
            double b = 0;
            



            Assert.AreEqual(1, eredmeny);

        }
        [TestMethod]
        public void TestOneBaseAnyExponent()
        {
            double eredmeny = new PowerCalculator();
            double a = 1;
            double b = 100;
            



            Assert.AreEqual(1, eredmeny);

        }
        [TestMethod]
        public void TestNegativeBaseEvenExponent()
        {
            double eredmeny = new PowerCalculator();
            double a = -3;
            double b = 4;
            



            Assert.AreEqual(81, eredmeny);

        }
        [TestMethod]
        public void TestNegativeBaseOddExponent()
        {
            double eredmeny = new PowerCalculator();
            double a = -2;
            double b = 3;
            



            Assert.AreEqual(-8, eredmeny);

        }
        [TestMethod]
        public void TestNegativeBaseNegativeExponent()
        {
            double eredmeny = new PowerCalculator();
            double a = -2;
            double b = -2;
            



            Assert.AreEqual(0.25, eredmeny);

        }
        
        

    }
}
