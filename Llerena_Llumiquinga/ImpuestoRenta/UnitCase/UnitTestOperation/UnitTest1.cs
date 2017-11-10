using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitCase;

namespace UnitTestOperation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCalcularSueldo1()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado=3803;
            valorActual = operation.SueldoAnual(350);
            Assert.AreEqual(valorActual,valorEsperado);
        }
        [TestMethod]
        public void TestMethodCalcularSueldo2()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 10866;
            valorActual = operation.SueldoAnual(1000);
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodCalcularSueldo3()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 11952;
            valorActual = operation.SueldoAnual(1100);
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodCalcularSueldo4()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 27165;
            valorActual = operation.SueldoAnual(2500);
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodCalcularSueldo5()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 41290;
            valorActual = operation.SueldoAnual(3800);
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodCalcularSueldo6()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 0;
            valorActual = operation.SueldoAnual(-10);
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodCalcularSueldo7()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 0;
            valorActual = operation.SueldoAnual(0);
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodLimiteImpuesto1()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 141;
            valorActual = operation.ImpuestoAnual(operation.SueldoAnual(1300));
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodLimiteImpuesto2()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 0;
            valorActual = operation.ImpuestoAnual(operation.SueldoAnual(-1));
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodLimiteImpuesto3()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 172390;
            valorActual = operation.ImpuestoAnual(operation.SueldoAnual(50000));
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodLimiteImpuesto4()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 17330;
            valorActual = operation.ImpuestoAnual(operation.SueldoAnual(9000));
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodLimiteImpuesto5()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 5433;
            valorActual = operation.ImpuestoAnual(operation.SueldoAnual(500));
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodLimiteImpuesto6()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 2597;
            valorActual = operation.ImpuestoAnual(operation.SueldoAnual(3000));
            Assert.AreEqual(valorActual, valorEsperado);
        }
        [TestMethod]
        public void TestMethodLimiteImpuesto7()
        {
            Operation operation = new Operation();
            double valorActual;
            double valorEsperado = 0;
            valorActual = operation.ImpuestoAnual(operation.SueldoAnual(0));
            Assert.AreEqual(valorActual, valorEsperado);
        }
    }
}
















