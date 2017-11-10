using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImpuestoRenta;

namespace UnitTestSueldoAnual
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrimerRango()
        {
            CalculoRenta calculoRenta = new CalculoRenta();
            double expectedR = 3803;
            expectedR = Math.Truncate(expectedR);
            double actualR;
            actualR = calculoRenta.SueldoAnual(350);
            actualR=Math.Truncate(actualR);
            Assert.AreEqual(expectedR, actualR);

        }

        [TestMethod]
        public void TestSegundoRango()
        {
            CalculoRenta calculoRenta = new CalculoRenta();
            double expectedR = 10866;
            double actualR;
            actualR = calculoRenta.SueldoAnual(1000);
            Assert.AreEqual(expectedR, actualR);

        }
        [TestMethod]
        public void TestTercerRango()
        {
            CalculoRenta calculoRenta = new CalculoRenta();
            double expectedR = 11952.6;
           expectedR= Math.Truncate(expectedR);
            double actualR;
            actualR = calculoRenta.SueldoAnual(1100);
            actualR= Math.Truncate(actualR);
            Assert.AreEqual(expectedR, actualR);

        }
        [TestMethod]
        public void TestCuartoRango()
        {
            CalculoRenta calculoRenta = new CalculoRenta();
            double expectedR = 27165;
            double actualR;
            actualR = calculoRenta.SueldoAnual(2500);
            Assert.AreEqual(expectedR, actualR);

        }
        [TestMethod]
        public void TestValor0()
        {
            CalculoRenta calculoRenta = new CalculoRenta();
            double expectedR = 0;
            double actualR;
            actualR = calculoRenta.SueldoAnual(0);
            Assert.AreEqual(expectedR, actualR);

        }
        [TestMethod]
        public void TestValoresNegativos()
        {
            CalculoRenta calculoRenta = new CalculoRenta();
            double expectedR = 0;
            double actualR;
            actualR = calculoRenta.SueldoAnual(-10);
            Assert.AreEqual(expectedR, actualR);

            expectedR = 0;
            actualR = calculoRenta.SueldoAnual(-100);
            Assert.AreEqual(expectedR, actualR);

            expectedR = 0;
            actualR = calculoRenta.SueldoAnual(-100000000);
            Assert.AreEqual(expectedR, actualR);
        }

        //Funcion ImpuestoRenta

        [TestMethod]
        public void TestImpuestoRenta()
        {
            CalculoRenta calculoRenta = new CalculoRenta();
            double expectedR = 389;
            double actualR;
            actualR = calculoRenta.ImpuestoRenta("16732");
            Assert.AreEqual(expectedR, actualR);
        }

        [TestMethod]
        public void TestImpuestoRentaPositivos()
        {
            CalculoRenta calculoRenta = new CalculoRenta();
            double expectedR;
            double actualR;
            expectedR = 388;
            actualR = calculoRenta.SueldoAnual(1539);
            actualR = calculoRenta.ImpuestoRenta(actualR.ToString());
            Assert.AreEqual(expectedR, actualR);
        }

        [TestMethod]
        public void TestImpuestoRentaNegativos()
        {
            CalculoRenta calculoRenta = new CalculoRenta();
            double expectedR;
            double actualR;
            expectedR = 0;
            actualR = calculoRenta.SueldoAnual(-100000000);
            actualR = calculoRenta.ImpuestoRenta(actualR.ToString());
            Assert.AreEqual(expectedR, actualR);
        }

        [TestMethod]
        public void TestImpuestoRentaLetras()
        {
            CalculoRenta calculoRenta = new CalculoRenta();
            double expectedR;
            double actualR;
            expectedR = 0;
            actualR = calculoRenta.ImpuestoRenta("1635f53gv");
            Assert.AreEqual(expectedR, actualR);
        }
        
       


    }
}
