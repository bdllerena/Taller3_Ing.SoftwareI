using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppParaPruebaIngSoftware;

namespace PruebaSuma
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Operation operation = new Operation();
            int xpectedR = 13;
            int actualR;
            actualR = operation.Add(8, 5);
            Assert.AreEqual(xpectedR,actualR);
        }

        [TestMethod]
        public void Iess350()
        {
            Operation operation = new Operation();
            double xpectedR = 3803;
            double actualR;
            actualR = operation.ImpuestoIessAnual(350);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void Iess1000()
        {
            Operation operation = new Operation();
            double xpectedR = 10866;
            double actualR;
            actualR = operation.ImpuestoIessAnual(1000);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void Iess1100()
        {
            Operation operation = new Operation();
            double xpectedR = 11952;
            double actualR;
            actualR = operation.ImpuestoIessAnual(1100);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void Iess2500()
        {
            Operation operation = new Operation();
            double xpectedR = 27165;
            double actualR;
            actualR = operation.ImpuestoIessAnual(2500);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void Iess0()
        {
            Operation operation = new Operation();
            double xpectedR = 0;
            double actualR;
            actualR = operation.ImpuestoIessAnual(0);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void IessMinus10()
        {
            Operation operation = new Operation();
            double xpectedR = 0;
            double actualR;
            actualR = operation.ImpuestoIessAnual(-10);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void AnualRenta375()
        {
            Operation operation = new Operation();
            double xpectedR = 0;
            double actualR;
            actualR = operation.CalcularImpuestoRentaAnual(375);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void AnualRenta1111()
        {
            Operation operation = new Operation();
            double xpectedR = 39;
            double actualR;
            actualR = operation.CalcularImpuestoRentaAnual(1111);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void AnualRenta3333()
        {
            Operation operation = new Operation();
            double xpectedR = 3140;
            double actualR;
            actualR = operation.CalcularImpuestoRentaAnual(3333);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void AnualRenta6565()
        {
            Operation operation = new Operation();
            double xpectedR = 10144;
            double actualR;
            actualR = operation.CalcularImpuestoRentaAnual(6565);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void AnualRenta11278()
        {
            Operation operation = new Operation();
            double xpectedR = 25126;
            double actualR;
            actualR = operation.CalcularImpuestoRentaAnual(11278);
            Console.WriteLine(actualR);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void AnualRenta0()
        {
            Operation operation = new Operation();
            double xpectedR = 0;
            double actualR;
            actualR = operation.CalcularImpuestoRentaAnual(0);
            Console.WriteLine(actualR);
            Assert.AreEqual(xpectedR, actualR);
        }

        [TestMethod]
        public void AnualRentaMinus10()
        {
            Operation operation = new Operation();
            double xpectedR = 0;
            double actualR;
            actualR = operation.CalcularImpuestoRentaAnual(-10);
            Console.WriteLine(actualR);
            Assert.AreEqual(xpectedR, actualR);
        }

    }
}
