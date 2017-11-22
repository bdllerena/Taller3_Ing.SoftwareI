using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImpuestoRenta;
namespace UnitImpuestoRenta
{
    [TestClass]
    public class UnitTest1
    {
        TablaImpuesto tabla = new TablaImpuesto();
        [TestMethod]
        public void TestCalcularSueldo1()
        {
            int sueldoACalcular = 350;
            int sueldoExpected = 3803;
            int sueldoActual = tabla.calculoSueldo(sueldoACalcular);
            Assert.AreEqual(sueldoActual, sueldoExpected);
        }

        [TestMethod]
        public void TestCalcularSueldo2()
        {
            int sueldoACalcular = 1000;
            int sueldoExpected = 10866;
            int sueldoActual = tabla.calculoSueldo(sueldoACalcular);
            Assert.AreEqual(sueldoActual, sueldoExpected);
        }

        [TestMethod]
        public void TestCalcularSueldo3()
        {
            int sueldoACalcular = 1100;
            int sueldoExpected = 11952;
            int sueldoActual = tabla.calculoSueldo(sueldoACalcular);
            Assert.AreEqual(sueldoActual, sueldoExpected);
        }

        [TestMethod]
        public void TestCalcularSueldo4()
        {
            int sueldoACalcular = 2500;
            int sueldoExpected = 27165;
            int sueldoActual = tabla.calculoSueldo(sueldoACalcular);
            Assert.AreEqual(sueldoActual, sueldoExpected);
        }

        [TestMethod]
        public void TestCalcularSueldo5()
        {
            int sueldoACalcular = 0;
            int sueldoExpected = 0;
            int sueldoActual = tabla.calculoSueldo(sueldoACalcular);
            Assert.AreEqual(sueldoActual, sueldoExpected);
        }

        [TestMethod]
        public void TestCalcularSueldo6()
        {
            int sueldoACalcular = -10;
            int sueldoExpected = 0;
            int sueldoActual = tabla.calculoSueldo(sueldoACalcular);
            Assert.AreEqual(sueldoActual, sueldoExpected);
        }

        [TestMethod]
        public void TestMethodCalcularImpuesto1()
        {
            int sueldoACalcular = 1100;
            int impuestoExpected =33;
            int impuestoActual = tabla.calcularImpuesto(sueldoACalcular);
            Assert.AreEqual(impuestoActual, impuestoExpected);
        }

        [TestMethod]
        public void TestMethodCalcularImpuesto2()
        {
            int sueldoACalcular = 2500;
            int impuestoExpected = 1782;
            int impuestoActual = tabla.calcularImpuesto(sueldoACalcular);
            Assert.AreEqual(impuestoActual, impuestoExpected);
        }

        [TestMethod]
        public void TestMethodCalcularImpuesto3()
        {
            int sueldoACalcular = -10;
            int impuestoExpected = 0;
            int impuestoActual = tabla.calcularImpuesto(sueldoACalcular);
            Assert.AreEqual(impuestoActual, impuestoExpected);
        }

        [TestMethod]
        public void TestMethodCalcularImpuesto4()
        {
            int sueldoACalcular = 350;
            int impuestoExpected = 0;
            int impuestoActual = tabla.calcularImpuesto(sueldoACalcular);
            Assert.AreEqual(impuestoActual, impuestoExpected);
        }

        [TestMethod]
        public void TestMethodCalcularImpuesto5()
        {
            int sueldoACalcular = 1000;
            int impuestoExpected = 0;
            int impuestoActual = tabla.calcularImpuesto(sueldoACalcular);
            Assert.AreEqual(impuestoActual, impuestoExpected);
        }
    }
}
