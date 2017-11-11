using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImpuestoRenta;

namespace PruebaUnitariaImpuesto
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSueldoNormal()
        {
            Calculos impuesto = new Calculos();
            int expected=3803;
            int actual=impuesto.CalcularSueldoAnual(350);
            Assert.AreEqual(expected,actual);

        }

        [TestMethod]
        public void TestSueldoNormal2()
        {
            Calculos impuesto = new Calculos();
            int expected = 10866;
            int actual = impuesto.CalcularSueldoAnual(1000);
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void TestSueldoNormal3()
        {
            Calculos impuesto = new Calculos();
            int expected = 11952;
            int actual = impuesto.CalcularSueldoAnual(1100);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestSueldoNormal4()
        {
            Calculos impuesto = new Calculos();
            int expected = 27165;
            int actual = impuesto.CalcularSueldoAnual(2500);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestSueldoNegativo()
        {
            Calculos impuesto = new Calculos();
            int expected = 0;
            int actual = impuesto.CalcularSueldoAnual(-10);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestSueldoNulo()
        {
            Calculos impuesto = new Calculos();
            int expected = 0;
            int actual = impuesto.CalcularSueldoAnual(0);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestImpuesto()
        {
            Calculos impuesto = new Calculos();
            int expected = 0;
            int actual = impuesto.CalcularImpuesto(impuesto.CalcularSueldoAnual(1000));
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestImpuestoR1()
        {
            Calculos impuesto = new Calculos();
            int expected =33;
            int actual = impuesto.CalcularImpuesto(impuesto.CalcularSueldoAnual(1100));
            Assert.AreEqual(expected, actual);

        }
        
        [TestMethod]
        public void TestImpuestoR2()
        {
            Calculos impuesto = new Calculos();
            int expected = -33;
            int actual = impuesto.CalcularImpuesto(impuesto.CalcularSueldoAnual(1100));
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestImpuestoR3()
        {
            Calculos impuesto = new Calculos();
            int expected = 1782;
            int actual = impuesto.CalcularImpuesto(impuesto.CalcularSueldoAnual(2500));
            Assert.AreEqual(expected, actual);

        }

        //Calculas desde aqui :v
        [TestMethod]
        public void TestImpuestoR4()
        {
            Calculos impuesto = new Calculos();
            int expected = 17330;
            int actual = impuesto.CalcularImpuesto(impuesto.CalcularSueldoAnual(9000));
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestImpuestoBig()
        {
            Calculos impuesto = new Calculos();
            int expected = 33;
            int actual = impuesto.CalcularImpuesto(impuesto.CalcularSueldoAnual(1100000000000000));
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestImpuestoR6()
        {
            Calculos impuesto = new Calculos();
            int expected = 33;
            int actual = impuesto.CalcularImpuesto(impuesto.CalcularSueldoAnual(-1100));
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestImpuestoR7()
        {
            Calculos impuesto = new Calculos();
            int expected = 17330;
            int actual = impuesto.CalcularImpuesto(impuesto.CalcularSueldoAnual(9000));
            Assert.AreEqual(expected, actual);

        }






    }
}
