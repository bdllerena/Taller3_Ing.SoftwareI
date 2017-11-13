using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto;

namespace UnitTestOperations
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Operation operation =new Operation();
            int expectResult=3803;
            int actualR = (int) operation.calculoAnual(350);
            Assert.AreEqual(expectResult, actualR);

        }
        [TestMethod]
        public void TestMethod2()
        {
            Operation operation = new Operation();
            int expectResult = 10866;
            int actualR = (int)operation.calculoAnual(1000);
            Assert.AreEqual(expectResult, actualR);

        }
        [TestMethod]
        public void TestMethod3()
        {
            Operation operation = new Operation();
            int expectResult = 11952;
            int actualR = (int)operation.calculoAnual(1100);
            Assert.AreEqual(expectResult, actualR);
        }
        [TestMethod]
               public void TestMethod4()
        {
            Operation operation =new Operation();
            int expectResult = 27165;
            int actualR = (int)operation.calculoAnual(2500);
            Assert.AreEqual(expectResult, actualR);

        }
        [TestMethod]
        public void TestMethod5()
        {
            Operation operation = new Operation();
            int expectResult =0;
            int actualR = (int)operation.calculoAnual(-10);
            Assert.AreEqual(expectResult, actualR);

        }
        [TestMethod]
        public void TestMethod6()
        {
            Operation operation = new Operation();
            int expectResult = 0;
            int temporal = (int)operation.calculoAnual(350);
            int actualR = (int)operation.impuesto(temporal);
            Assert.AreEqual(expectResult, actualR);

        }
        [TestMethod]
        public void rangoMil()
        {
            Operation operation = new Operation();
            int expectResult = 0;
            int temporal = (int)operation.calculoAnual(1000);
            int actualR = (int)operation.impuesto(temporal);
            Assert.AreEqual(expectResult, actualR);

        }
        [TestMethod]
        public void rangoMilCien()
        {
            Operation operation = new Operation();
            int expectResult = 33;
            int temporal = (int)operation.calculoAnual(1100);
            int actualR = (int)operation.impuesto(temporal);
            Assert.AreEqual(expectResult, actualR);

        }
        [TestMethod]
        public void RangoCincoMil()
        {
            Operation operation = new Operation();
            int expectResult = 6415;
            int temporal = (int)operation.calculoAnual(5000);
            int actualR = (int)operation.impuesto(temporal);
            Assert.AreEqual(expectResult, actualR);

        }
   
        
    }
}
