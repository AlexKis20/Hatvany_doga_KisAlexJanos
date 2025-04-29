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

            double a = 2;
            double b = 3;
            double eredmeny = new PowerCalculator();
            
            

            Assert.AreEqual(8, eredmeny);

        }
        [TestMethod]
        public void TestZeroExponent()
        {

            double a = 5;
            double b = 0;
            double eredmeny = new PowerCalculator();



            Assert.AreEqual(1, eredmeny);

        }
        [TestMethod]
        public void TestNegativeExponent()
        {

            double a = 2;
            double b = -2;
            double eredmeny = new PowerCalculator();



            Assert.AreEqual(0.25, eredmeny);

        }
        [TestMethod]
        public void TestZeroBasePositiveExponent()
        {

            double a = 0;
            double b = 5;
            double eredmeny = new PowerCalculator();



            Assert.AreEqual(0, eredmeny);

        }
        [TestMethod]
        public void TestZeroBaseZeroExponent()
        {

            double a = 0;
            double b = 0;
            double eredmeny = new PowerCalculator();



            Assert.AreEqual(1, eredmeny);

        }
        [TestMethod]
        public void TestOneBaseAnyExponent()
        {

            double a = 1;
            double b = 100;
            double eredmeny = new PowerCalculator();



            Assert.AreEqual(1, eredmeny);

        }
        [TestMethod]
        public void TestNegativeBaseEvenExponent()
        {

            double a = -3;
            double b = 4;
            double eredmeny = new PowerCalculator();



            Assert.AreEqual(81, eredmeny);

        }
        [TestMethod]
        public void TestNegativeBaseOddExponent()
        {

            double a = -2;
            double b = 3;
            double eredmeny = new PowerCalculator();



            Assert.AreEqual(-8, eredmeny);

        }
        [TestMethod]
        public void TestNegativeBaseNegativeExponent()
        {

            double a = -2;
            double b = -2;
            double eredmeny = new PowerCalculator();



            Assert.AreEqual(0.25, eredmeny);

        }
        
        

    }
}
